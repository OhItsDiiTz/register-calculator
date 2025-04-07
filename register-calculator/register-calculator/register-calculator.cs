using register_calculator.Classes;
using System.Windows.Forms;

namespace register_calculator
{
    public partial class Form1 : Form
    {
        private List<NumericUpDown> value_list = new List<NumericUpDown>();
        private List<MenuItems> menuItems = new List<MenuItems>();
#if CREAMPIES
        private float PDDiscount = 0.25F;
#endif
        private Label labels;
        private NumericUpDown values;

        public Form1()
        {
            InitializeComponent();

#if CREAMPIES
            menuItems.Add(new MenuItems("sbic", "Strawberry Ice Cream", 300));
            menuItems.Add(new MenuItems("dcic", "Double Chocolate Ice Cream", 300));
            menuItems.Add(new MenuItems("tcps", "The Cream Pie Special", 300));
            menuItems.Add(new MenuItems("dte", "DT's Energy", 250));
            menuItems.Add(new MenuItems("stss", "Summertime Sweetness Slushie", 250));
            menuItems.Add(new MenuItems("vmic", "Vanilla Mint Ice Cream", 200));
            menuItems.Add(new MenuItems("bis", "Berry Infusion Slushie", 150));
#endif

#if UPNATOM
            menuItems.Add(new MenuItems("1mcs", "Mission Control Special", 200));
            menuItems.Add(new MenuItems("2tfmn", "The Fat Man Nachos", 300));
            menuItems.Add(new MenuItems("3hdpnr", "Hyerdrive Punch & Rings", 3500));
            menuItems.Add(new MenuItems("4whlo", "We Have Lift Off", 14000));
            menuItems.Add(new MenuItems("5jthc", "Jabba The Hutt Combo", 14000));
            menuItems.Add(new MenuItems("7acc", "Atomic C#ck Combo", 17000));

            menuItems.Add(new MenuItems("rfsne", "Rocket Flame Steak & Eggs", 100));
            menuItems.Add(new MenuItems("hdfp", "Hyper Drive Fruit Punch", 200));
            menuItems.Add(new MenuItems("cn", "Cantina Nachos", 200));
            menuItems.Add(new MenuItems("a11c", "Apollo 11 Coffee", 300));
            menuItems.Add(new MenuItems("sr", "Saturn Rings", 200));
            menuItems.Add(new MenuItems("tfm", "The Fat Man", 500));
            menuItems.Add(new MenuItems("akp", "Agent K Pie", 400));
            menuItems.Add(new MenuItems("jmt", "Jedi Mind Trick", 500));
            menuItems.Add(new MenuItems("dab", "Double Atomic Burger", 500));
            menuItems.Add(new MenuItems("tac", "The Atomic C#ck", 500));
            menuItems.Add(new MenuItems("ac", "Arcade Card", 500));
#endif

#if UWUCAFE
            menuItems.Add(new MenuItems("cms", "Chocolate Marshmallows Sandy", 100));
            menuItems.Add(new MenuItems("vms", "Vanilla Marshmallows Sandy", 100));
            menuItems.Add(new MenuItems("cupcake", "Cupcake", 150));
            menuItems.Add(new MenuItems("savorypancake", "Savory Pancake", 150));
            menuItems.Add(new MenuItems("budhabowl", "Budha Bowl", 200));
            menuItems.Add(new MenuItems("sushi", "Sushi", 150));
            menuItems.Add(new MenuItems("misosoup", "Miso Soup", 300));
            menuItems.Add(new MenuItems("mintybt", "Minty Boba-Tea", 100));
            menuItems.Add(new MenuItems("berrybt", "Berry Boba-Tea", 150));
            menuItems.Add(new MenuItems("roseybt", "Rosey Boba-Tea", 100));
            menuItems.Add(new MenuItems("angelset", "Angel Set", 4000));
            menuItems.Add(new MenuItems("sushiset", "Sushi Set", 3000));
            menuItems.Add(new MenuItems("sweetset", "Sweetie Set", 3000));
            menuItems.Add(new MenuItems("bentobox", "Bentoboxes", 2000));
#endif

#if MATERIALS
            menuItems.Add(new MenuItems("glass", "Glass", 10));
            menuItems.Add(new MenuItems("plastic", "Plastic", 10));
            menuItems.Add(new MenuItems("steel", "Steel", 10));
            menuItems.Add(new MenuItems("iron", "Iron", 10));
            menuItems.Add(new MenuItems("copper", "Copper", 10));
            menuItems.Add(new MenuItems("metal_scrap", "Metal Scrap", 15));
            menuItems.Add(new MenuItems("aluminium", "Aluminium", 12));
            menuItems.Add(new MenuItems("rubber", "Rubber", 25));
#endif

#if BURGERSHOT
            menuItems.Add(new MenuItems("hs", "Heartstopper", 250));
            menuItems.Add(new MenuItems("if", "Itadory Fries", 300));
            menuItems.Add(new MenuItems("pb", "Peta Burger", 150));
            menuItems.Add(new MenuItems("fb", "Fifty's Burger", 150));
            menuItems.Add(new MenuItems("tt", "The Torpedo", 165));
            menuItems.Add(new MenuItems("sb", "Stroke Burger", 175));
            menuItems.Add(new MenuItems("ms", "Money Shot", 150));
            menuItems.Add(new MenuItems("gg", "Glizzy Gobbler", 650));
            menuItems.Add(new MenuItems("te", "Ty's Ex", 200));
            menuItems.Add(new MenuItems("bb", "Big Boi", 250));
            menuItems.Add(new MenuItems("ns", "Nut's Shake", 200));
            menuItems.Add(new MenuItems("sd", "Soft Drink", 250));
#endif

#if HOGSPUB
            menuItems.Add(new MenuItems("cf", "Chocolate Frogs", 200));
            menuItems.Add(new MenuItems("ded", "Death Eaters Delight", 200));
            menuItems.Add(new MenuItems("va", "Venoms Ale", 200));
            menuItems.Add(new MenuItems("lep", "Lizzy's Enchanted Potion", 200));
            menuItems.Add(new MenuItems("drbr", "Dragons Breath", 200));
            menuItems.Add(new MenuItems("lxglp", "Lizz x Grizz Love Potion", 200));
            menuItems.Add(new MenuItems("bb", "Butterbeer", 200));
            menuItems.Add(new MenuItems("ebf", "Everything Bean Flavor", 200));
            menuItems.Add(new MenuItems("lgof", "Lizzy's Goblet of Fire", 200));
            menuItems.Add(new MenuItems("gsct", "Golden Snitch Chocolate Truffle", 200));
            menuItems.Add(new MenuItems("gw", "Grizzwoods", 200));
            menuItems.Add(new MenuItems("ojv", "Og Juice Vape", 200));
            menuItems.Add(new MenuItems("rd", "Rusty Dust", 200));
#endif

#if BAHAMAMAMAS
            menuItems.Add(new MenuItems("bbf", "Blueberry Faygo", 150));
            menuItems.Add(new MenuItems("ajs", "Angelic Jell-O shot", 200));
            menuItems.Add(new MenuItems("br", "Black Russian", 350));
            menuItems.Add(new MenuItems("pbm", "Playboy Martini", 300));
            menuItems.Add(new MenuItems("maitai", "Mai Tai", 300));
            menuItems.Add(new MenuItems("redwine", "Red Wine", 500));
            menuItems.Add(new MenuItems("nikkirita", "Nikki Rita", 400));
            menuItems.Add(new MenuItems("bsb", "Bahamas signature Bacardi", 500));
            menuItems.Add(new MenuItems("henny", "Henny", 1000));
            menuItems.Add(new MenuItems("juansof", "Juans Old Fashioned", 500));
            menuItems.Add(new MenuItems("brianswaste", "Brians Waste", 250));
            menuItems.Add(new MenuItems("1942don", "1942 Don", 10000));
            menuItems.Add(new MenuItems("comebackcrackle", "Come Back Crackle Jacks", 200));
            menuItems.Add(new MenuItems("backbreakerbacon", "Back Breaker Bacon", 200));
            menuItems.Add(new MenuItems("ischs", "I Should Call Her Salad", 200));
            menuItems.Add(new MenuItems("bamiastew", "Hot Wings", 250));
            menuItems.Add(new MenuItems("mhdm", "Miss Her Dear Meet", 250));
            menuItems.Add(new MenuItems("jampat", "Jamaican Patty", 300));
            menuItems.Add(new MenuItems("jp", "Juan's Pizza", 300));
            menuItems.Add(new MenuItems("jl", "Juan's Lasagna", 300));
            menuItems.Add(new MenuItems("stikkinikki", "Stikki Nikki", 350));
            menuItems.Add(new MenuItems("briansbrian", "Brian's Brian", 400));
            menuItems.Add(new MenuItems("briskomelt", "Brisko Melt", 500));
            menuItems.Add(new MenuItems("allavodka", "Alla Vodka", 500));
#endif
#if TACOSHOP
            menuItems.Add(new MenuItems("sms", "Special Mandarin Soda", 150));
            menuItems.Add(new MenuItems("fps", "Fruit Punch Soda", 200));
            menuItems.Add(new MenuItems("at", "Asian Tacos", 200));
            menuItems.Add(new MenuItems("ae", "Asian Enchiladas", 200));
            menuItems.Add(new MenuItems("asiantamales", "Asian Tamales", 150));
#endif

#if POPSDINER
            menuItems.Add(new MenuItems("ale", "ALE 7", 200));
            menuItems.Add(new MenuItems("hottoddy", "HOT TODDY", 200));
            menuItems.Add(new MenuItems("3way", "3-WAY", 225));
            menuItems.Add(new MenuItems("4way", "4-WAY", 250));
            menuItems.Add(new MenuItems("goettabsandwich", "GOETTA BREAKFAST SANDWICH", 200));
            menuItems.Add(new MenuItems("redsgrandslam", "REDS GRAND SLAM", 200));
            menuItems.Add(new MenuItems("montyinribs", "MONTY INN RIBS", 200));
            menuItems.Add(new MenuItems("grippers", "GRIPPERS", 175));
            menuItems.Add(new MenuItems("popsxuwubobatea", "POPSxUwU BOBA TEA", 350));
            menuItems.Add(new MenuItems("5way", "5-WAY", 375));
#endif

            int count = 0;
            foreach (MenuItems item in menuItems)
            {
                //NumericUpDown start = 12, 12
                //Label start = 85, 14
                NumericUpDown numeric_up_down = new NumericUpDown();
                Label label = new Label();
                ((System.ComponentModel.ISupportInitialize)(numeric_up_down)).BeginInit();

                numeric_up_down.Location = new System.Drawing.Point(12, 27 + (count * 26));
                numeric_up_down.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
                numeric_up_down.Name = item.ShortName;
                numeric_up_down.Size = new System.Drawing.Size(67, 20);
                numeric_up_down.TabIndex = 34 + count;

                label.AutoSize = true;
                label.Location = new System.Drawing.Point(85, 29 + (count * 26));
                label.Name = $"{item.ShortName}_label";
                label.Size = new System.Drawing.Size(108, 13);
                label.TabIndex = 64 + menuItems.Count + count;
                label.Text = item.Name;

                value_list.Add(numeric_up_down);
                Controls.Add(numeric_up_down);
                Controls.Add(label);
                ((System.ComponentModel.ISupportInitialize)(numeric_up_down)).EndInit();
                count++;
            }
            int padding = 25;
            this.Size = new System.Drawing.Size(500, 100 + (menuItems.Count * padding));
            this.MaximumSize = new System.Drawing.Size(500, 100 + (menuItems.Count * padding));
            this.MinimumSize = new System.Drawing.Size(500, 100 + (menuItems.Count * padding));

#if CREAMPIES
            this.Text = "CreamPies Calculator";
#elif UPNATOM
            this.Text = "Up N Atom Calculator";
#elif UWUCAFE
            this.Text = "UWU Cafe Calculator";
#elif MATERIALS
            this.Text = "Materials Calculator";
#elif BURGERSHOT
            this.Text = "Burger Shot Calculator";
#elif HOGSPUB
            this.Text = "Hogs Pub & Restaurant Calculator";
#elif BAHAMAMAMAS
            this.Text = "Bahama Mamas Calculator";
#elif TACOSHOP
            this.Text = "Taco Shop Calculator";
#elif POPSDINER
            this.Text = "Pops Diner Calculator";
#endif


        }

        private void CalculateCostMenuItem_Click(object sender, EventArgs e)
        {
            int amount = 0;
            int total = 0;
            string total_string = "";
            foreach (NumericUpDown nup in value_list)
            {
                if (int.TryParse(nup.Value.ToString(), out amount))
                {
                    if (amount != 0)
                    {
                        MenuItems menuitem = FindItem(nup.Name);
                        int final = (amount * menuitem.Price);
#if CREAMPIES
                        int value = CB_ems_pd_discount.Checked ? (final - (int)((float)final * PDDiscount)) : final;
#elif UPNATOM
                        int value = final;
#else
                        int value = final;
#endif
                        total += value;
                        total_string += $"{amount}x {menuitem.Name} - ${value:n0}\n";
                    }
                }
            }

#if POPSDINER
            if (total >= 100000) total = (int)((float)total * 0.9);
#endif

            Clipboard.SetText($"{total:n0}\n{total_string}");
            MessageBox.Show("The order has been copied to your clipboard, to paste Right Click and Paste or ctrl + v", "Final", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearItemsMenuItem_Click(object sender, EventArgs e)
        {
            foreach (NumericUpDown nup in value_list)
            {
                nup.Value = 0;
            }
        }

        private MenuItems FindItem(string shortname)
        {
            foreach (MenuItems item in menuItems)
            {
                if (shortname == item.ShortName)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
