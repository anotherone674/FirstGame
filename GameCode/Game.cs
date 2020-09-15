using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Engine;

namespace SuperAdventures
{

    public partial class SuperAdventures : Form
    {
        //Variables to be used by the program
        private Player _player;
        private Monster _currentMonster;
        private const string PLAYER_DATA_FILE_NAME = "PlayerData.xml";

        public SuperAdventures()
        {
            InitializeComponent();

            //Welcome message, determines if an XML file already exists :)
            if (File.Exists(PLAYER_DATA_FILE_NAME))
            {
                _player = Player.CreatePlayerFromXmlString(File.ReadAllText(PLAYER_DATA_FILE_NAME));
                rtbMessages.Text += "Welcome back!" + Environment.NewLine;
                rtbMessages.Text += Environment.NewLine;
            }
            else
            {
                _player = Player.CreateDefaultPlayer();
                rtbMessages.Text += "Welcome to the game!" + Environment.NewLine;
                rtbMessages.Text += Environment.NewLine;
            }

            //
            // UI DATA
            //

            //Databinding
            lblHitPoints.DataBindings.Add("Text", _player, "CurrentHitPoints");
            lblGold.DataBindings.Add("Text", _player, "Gold");
            lblExperience.DataBindings.Add("Text", _player, "ExperiencePoints");
            lblLevel.DataBindings.Add("Text", _player, "Level");

            MoveTo(_player.CurrentLocation);

            cboWeapons.DataSource = _player.Weapons;
            cboWeapons.DisplayMember = "Name";
            cboWeapons.ValueMember = "Id";

            //DataGridView management, changes how the quest box and inventory work (to an extent)

            //Inventory
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.AutoGenerateColumns = false;

            dgvInventory.DataSource = _player.Inventory;

            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 197,
                DataPropertyName = "Description"
            });

            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity",
                DataPropertyName = "Quantity"
            });

            //Quests
            dgvQuests.RowHeadersVisible = false;
            dgvQuests.AutoGenerateColumns = false;

            dgvQuests.DataSource = _player.Quests;

            dgvQuests.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 197,
                DataPropertyName = "Name",
            });

            dgvQuests.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Done?",
                DataPropertyName = "IsCompleted",
            });

            if (_player.CurrentWeapon != null)
            {
                cboWeapons.SelectedItem = _player.CurrentWeapon;
            }

            //Sets datasources for comboboxes
            cboWeapons.SelectedIndexChanged += cboWeapons_SelectedIndexChanged;

            cboSpells.DataSource = _player.Spells;
            cboSpells.DisplayMember = "Name";
            cboSpells.ValueMember = "Id";

            cboPotions.DataSource = _player.Potions;
            cboPotions.DisplayMember = "Name";
            cboPotions.ValueMember = "Id";

            _player.PropertyChanged += PlayerOnPropertyChanged;

            MoveTo(_player.CurrentLocation);
        }

        //Checks if the player has weapons, potions, and spells, respectively
        private void PlayerOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (propertyChangedEventArgs.PropertyName == "Weapons")
            {
                cboWeapons.DataSource = _player.Weapons;

                if(!_player.Weapons.Any())
                {
                    cboWeapons.Visible = false;
                    btnUseWeapon.Visible = false;
                }
            }

            if (propertyChangedEventArgs.PropertyName == "Potions")
            {
                cboPotions.DataSource = _player.Potions;

                if (!_player.Potions.Any())
                {
                    cboPotions.Visible = false;
                    btnUsePotion.Visible = false;
                }
            }

            if (propertyChangedEventArgs.PropertyName == "Spells")
            {
                cboSpells.DataSource = _player.Spells;

                if (!_player.Spells.Any())
                {
                    cboSpells.Visible = false;
                    btnUseSpell.Visible = false;
                }
            }
        }

        //Updates the UI with player stats
        public void UpdatePlayerStats(Player player)
        {
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        //
        // LOCATION & MOVEMENT
        //

        //"Moves" the player to a new location, depending on the btn_Click event used
        private void btnNorth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToNorth);
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToEast);
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToSouth);
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToWest);
        }

        //Determines if the player needs/has an item required to enter the next location
        private void MoveTo(Location newLocation)
        {
            if (!_player.HasRequiredItemToEnterThisLocation(newLocation))
            {
                rtbMessages.Text += "You must have a " + newLocation.ItemRequiredToEnter.Name + " to enter." + Environment.NewLine;
                ScrollToBottomOfMessages();

                return;
            }

            //Determines if specific buttons should be visible, depending on newLocation
            _player.CurrentLocation = newLocation;

            btnNorth.Visible = (newLocation.LocationToNorth != null);
            btnEast.Visible = (newLocation.LocationToEast != null);
            btnSouth.Visible = (newLocation.LocationToSouth != null);
            btnWest.Visible = (newLocation.LocationToWest != null);

            rtbLocation.Text = newLocation.Name + Environment.NewLine;
            rtbLocation.Text += newLocation.Description + Environment.NewLine;

            _player.CurrentHitPoints = _player.MaximumHitPoints;
            _player.MaximumHitPoints = _player.Level * 10;

            btnTrade.Visible = (_player.CurrentLocation.VendorHere != false);

            //Determines if a location-based quest is availabe, and assigns quest if true

            if (newLocation.QuestAvailableHere != null)
            {

                bool playerAlreadyHasQuest = _player.HasThisQuest(newLocation.QuestAvailableHere);
                bool playerAlreadyCompletedQuest = _player.CompletedThisQuest(newLocation.QuestAvailableHere);

                if (playerAlreadyHasQuest)
                {

                    if (!playerAlreadyCompletedQuest)
                    {
                        bool playerHasAllItemsToCompleteQuest = _player.HasAllQuestCompletionItems(newLocation.QuestAvailableHere);

                        if (playerHasAllItemsToCompleteQuest)
                        {
                            rtbMessages.Text += Environment.NewLine;
                            rtbMessages.Text += "You've completed the '" + newLocation.QuestAvailableHere.Name + "' quest!" + Environment.NewLine;
                            ScrollToBottomOfMessages();

                            _player.RemoveQuestCompletionItems(newLocation.QuestAvailableHere);

                            rtbMessages.Text += "As a reward, you recieve: " + Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardGold.ToString() + " gold" + Environment.NewLine;
                            rtbMessages.Text += "And some gifts." + Environment.NewLine;
                            rtbMessages.Text += Environment.NewLine;
                            ScrollToBottomOfMessages();

                            _player.ExperiencePoints += newLocation.QuestAvailableHere.RewardExperiencePoints;
                            _player.Gold += newLocation.QuestAvailableHere.RewardGold;

                            _player.AddQuestRewardItems(newLocation.QuestAvailableHere);

                            _player.MarkQuestCompleted(newLocation.QuestAvailableHere);
                        }
                    }
                }
                else
                {

                    rtbMessages.Text += "You recieve the '" + newLocation.QuestAvailableHere.Name + "' quest." + Environment.NewLine;
                    rtbMessages.Text += newLocation.QuestAvailableHere.Description + Environment.NewLine;
                    rtbMessages.Text += "To complete it, return with: " + Environment.NewLine;
                    foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                    {
                        if (qci.Quantity == 1)
                        {
                            rtbMessages.Text += qci.Quantity.ToString() + " " + qci.Details.Name + Environment.NewLine;
                        }
                        else
                        {
                            rtbMessages.Text += qci.Quantity.ToString() + " " + qci.Details.NamePlural + Environment.NewLine;
                        }
                    }
                    rtbMessages.Text += Environment.NewLine;
                    ScrollToBottomOfMessages();

                    _player.Quests.Add(new PlayerQuest(newLocation.QuestAvailableHere));
                }
            }

            //Determines if MonsterLivingHere = true. If true, initiates a combat encounter and displays combat options, if false, keeps combat options hidden
            if (newLocation.MonsterLivingHere != null)
            {
                rtbMessages.Text += Environment.NewLine;
                rtbMessages.Text += "You see a " + newLocation.MonsterLivingHere.Name;
                rtbMessages.Text += Environment.NewLine;
                ScrollToBottomOfMessages();

                Monster standardMonster = World.MonsterByID(newLocation.MonsterLivingHere.ID);

                _currentMonster = new Monster(standardMonster.ID, standardMonster.Name, standardMonster.MaximumDamage, standardMonster.RewardExperiencePoints, standardMonster.RewardGold, standardMonster.CurrentHitPoints, standardMonster.MaximumHitPoints);

                foreach (LootItem lootItem in standardMonster.LootTable)
                {
                    _currentMonster.LootTable.Add(lootItem);
                }
                cboWeapons.Visible = _player.Weapons.Any();
                cboPotions.Visible = _player.Potions.Any();
                cboSpells.Visible = _player.Spells.Any();
                btnUseWeapon.Visible = _player.Weapons.Any();
                btnUsePotion.Visible = _player.Potions.Any();
                btnUseSpell.Visible = _player.Spells.Any();
            }
            else
            {
                _currentMonster = null;

                cboWeapons.Visible = false;
                cboPotions.Visible = false;
                cboSpells.Visible = false;
                btnUseWeapon.Visible = false;
                btnUsePotion.Visible = false;
                btnUseSpell.Visible = false;
            }
        }

        //
        // COMBAT
        //

        //Manages btnUseWeapon as well as the next turn and a possible death instance
        private void btnUseWeapon_Click(object sender, EventArgs e)
        {
            Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;

            int damageToMonster = RandomNumberGenerator.NumberBetween(currentWeapon.MinimumDamage, currentWeapon.MaximumDamage);

            _currentMonster.CurrentHitPoints -= damageToMonster;

            rtbMessages.Text += "You hit the " + _currentMonster.Name + " for " + damageToMonster.ToString() + " points of combat damage." + Environment.NewLine;
            
            if (_currentMonster.CurrentHitPoints <= 0)
            {
                rtbMessages.Text += "The " + _currentMonster.Name + " falls to the ground, defeated." + Environment.NewLine;
                rtbMessages.Text += Environment.NewLine;

                _player.ExperiencePoints += _currentMonster.RewardExperiencePoints;
                rtbMessages.Text += "You earn " + _currentMonster.RewardExperiencePoints.ToString() + " experience points." + Environment.NewLine;
                ScrollToBottomOfMessages();

                List<InventoryItem> lootedItems = new List<InventoryItem>();

                foreach (LootItem lootItem in _currentMonster.LootTable)
                {
                    if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropPercentage)
                    {
                        lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                    }
                }

                if (lootedItems.Count == 0)
                {
                    foreach (LootItem lootItem in _currentMonster.LootTable)
                    {
                        if (lootItem.IsDefaultItem)
                        {
                            lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                        }
                    }
                }

                foreach (InventoryItem inventoryItem in lootedItems)
                {
                    _player.AddItemToInventory(inventoryItem.Details);

                    if (inventoryItem.Quantity == 1)
                    {
                        rtbMessages.Text += "You find " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Name + Environment.NewLine;
                        ScrollToBottomOfMessages();
                    }
                    else
                    {
                        rtbMessages.Text += "You find " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.NamePlural + Environment.NewLine;
                        ScrollToBottomOfMessages();
                    }
                }

                //Endgame message, currently inactive. Hoping to bring in after some updates
                /*if (_currentMonster.MaximumHitPoints >= 80)
                {
                    if (_currentMonster.CurrentHitPoints <= 0)
                    {
                        rtbMessages.Text += Environment.NewLine + "Congragulations! You've beaten the game" + Environment.NewLine + "Be sure to finish your last quests!";
                        rtbMessages.Text += Environment.NewLine;
                        ScrollToBottomOfMessages();
                    }
                }*/

                lblGold.Text = _player.Gold.ToString();
                lblExperience.Text = _player.ExperiencePoints.ToString();
                lblLevel.Text = _player.Level.ToString();

                rtbMessages.Text += Environment.NewLine;
                ScrollToBottomOfMessages();

                MoveTo(_player.CurrentLocation);
            }
            else
            {
                int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

                rtbMessages.Text += "The " + _currentMonster.Name + " hits you for " + damageToPlayer.ToString() + " points of damage." + Environment.NewLine;
                rtbMessages.Text += Environment.NewLine;
                ScrollToBottomOfMessages();

                _player.CurrentHitPoints -= damageToPlayer;

                if(_player.CurrentHitPoints <= 0)
                {
                    rtbMessages.Text += "The " + _currentMonster.Name + " knocked you out!" + Environment.NewLine;
                    rtbMessages.Text += Environment.NewLine;
                    ScrollToBottomOfMessages();

                    MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
                }
            }
        }

        //Manages btnUsePotion, and determines what kind of "potion" is used, with unique messages and either a buff to currentHitPoints or MaximumDamage
        private void btnUsePotion_Click(object sender, EventArgs e)
        {
            HealingPotion potion = (HealingPotion)cboPotions.SelectedItem;

            _player.CurrentHitPoints = (_player.CurrentHitPoints + potion.AmountToHeal);

            _player.CurrentWeapon.MaximumDamage = (_player.CurrentWeapon.MaximumDamage + potion.DamageAdded);

            if(potion.IsPotion)
            {
                rtbMessages.Text += "You drink the " + potion.Name + Environment.NewLine;
                ScrollToBottomOfMessages();
            }
            else if(potion.IsPoison)
            {
                rtbMessages.Text += "You apply the " + potion.Name + " to your weapon " + Environment.NewLine;
                ScrollToBottomOfMessages();
            }
            else if(potion.IsFood)
            {
                rtbMessages.Text += "You eat the " + potion.Name + ". It's delicious!" + Environment.NewLine;
                ScrollToBottomOfMessages();
            }
            else if (potion.IsDrink)
            {
                rtbMessages.Text += "You drink the " + potion.Name + ". It's delicious!" + Environment.NewLine;
                ScrollToBottomOfMessages();
            }

            if (_player.CurrentHitPoints > _player.MaximumHitPoints)
            {
                _player.CurrentHitPoints = _player.MaximumHitPoints;
            }

            _player.RemoveItemFromInventory(potion, 1);
        }

        //Manages btnUseSpell, including the next monster turn and a possible death instance
        private void btnUseSpell_Click(object sender, EventArgs e)
        {
            Spell currentSpell = (Spell)cboSpells.SelectedItem;

            int damageToMonster = RandomNumberGenerator.NumberBetween(currentSpell.MinimumDamage, currentSpell.MaximumDamage);

            _currentMonster.CurrentHitPoints -= damageToMonster;

            rtbMessages.Text += "You cast upon the " + _currentMonster.Name + " for " + damageToMonster.ToString() + " points of magic damage." + Environment.NewLine;

            if (_currentMonster.CurrentHitPoints <= 0)
            {
                rtbMessages.Text += Environment.NewLine;
                rtbMessages.Text += "The " + _currentMonster.Name + " falls to the ground, defeated." + Environment.NewLine;
                rtbMessages.Text += Environment.NewLine;

                _player.ExperiencePoints += _currentMonster.RewardExperiencePoints;
                rtbMessages.Text += "You earn " + _currentMonster.RewardExperiencePoints.ToString() + " expereince points." + Environment.NewLine;
                rtbMessages.Text += Environment.NewLine;
                ScrollToBottomOfMessages();

                List<InventoryItem> lootedItems = new List<InventoryItem>();

                foreach (LootItem lootItem in _currentMonster.LootTable)
                {
                    if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropPercentage)
                    {
                        lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                    }
                }

                if (lootedItems.Count == 0)
                {
                    foreach (LootItem lootItem in _currentMonster.LootTable)
                    {
                        if (lootItem.IsDefaultItem)
                        {
                            lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                        }
                    }
                }

                foreach (InventoryItem inventoryItem in lootedItems)
                {
                    _player.AddItemToInventory(inventoryItem.Details);

                    if (inventoryItem.Quantity == 1)
                    {
                        rtbMessages.Text += "You find " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Name + Environment.NewLine;
                        ScrollToBottomOfMessages();
                    }
                    else
                    {
                        rtbMessages.Text += "You find " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.NamePlural + Environment.NewLine;
                        ScrollToBottomOfMessages();
                    }
                }

                lblGold.Text = _player.Gold.ToString();
                lblExperience.Text = _player.ExperiencePoints.ToString();
                lblLevel.Text = _player.Level.ToString();

                rtbMessages.Text += Environment.NewLine;
                ScrollToBottomOfMessages();

                MoveTo(_player.CurrentLocation);
            }
            else
            {
                int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

                rtbMessages.Text += "The " + _currentMonster.Name + " hits you for " + damageToPlayer.ToString() + " points of damage." + Environment.NewLine;
                ScrollToBottomOfMessages();

                _player.CurrentHitPoints -= damageToPlayer;

                if (_player.CurrentHitPoints <= 0)
                {
                    rtbMessages.Text += "The " + _currentMonster.Name + " knocked you out!" + Environment.NewLine;
                    rtbMessages.Text += Environment.NewLine;
                    ScrollToBottomOfMessages();

                    MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
                }
            }
        }

        //
        // MISC
        //

        //Opens trading screen on btn_Clicked event
        private void btnTrade_Click(object sender,  EventArgs e)
        {
            TradingScreen tradingScreen = new TradingScreen(_player);
            tradingScreen.StartPosition = FormStartPosition.CenterParent;
            tradingScreen.ShowDialog(this);
        }

        //Manages "autoscroll"
        private void ScrollToBottomOfMessages()
        {
            rtbMessages.SelectionStart = rtbMessages.Text.Length;
            rtbMessages.ScrollToCaret();
        }

        //Event writes to XML when the game closes
        private void SuperAdventures_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(PLAYER_DATA_FILE_NAME, _player.ToXmlString());
        }

        //Manages current weapons
        private void cboWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            _player.CurrentWeapon = (Weapon)cboWeapons.SelectedItem;
        }

        //Empty event
        private void dgvInventory_Scroll(object sender, ScrollEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
        }
    }
}