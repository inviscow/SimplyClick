using Gma.System.MouseKeyHook;
using SimplyClick.Handlers;

namespace SimplyClick
{
    public partial class Menu : Form
    {
        private static IKeyboardMouseEvents? m_GlobalHook;
        private static Dictionary<Combination, Action> assignment = new Dictionary<Combination, Action>();

        public Menu()
        {
            InitializeComponent();
            // https://github.com/gmamaladze/globalmousekeyhook/blob/vNext/examples/ConsoleHook/QuickStart.cs
            m_GlobalHook = Hook.GlobalEvents();
            var keybind = Combination.TriggeredBy(Keys.F7);
            Action stopClickAction = ToggleClickingAction;
            assignment = new Dictionary<Combination, Action>
            {
                {keybind, stopClickAction}
            };
            Hook.GlobalEvents().OnCombination(assignment);

            // TODO: Set saved values from a file
        }

        private void ToggleClickingAction()
        {
            if (ToggleCheckbox.Checked)
            {
                ToggleCheckbox.Checked = false;
            }
            else
            {
                ToggleCheckbox.Checked = true;
            }
        }

        private void ToggleCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)DelayTypeList.SelectedItem))
                return;

            if (ToggleCheckbox.Checked)
            {
                Autoclick.StartClicking((float)DelayBox.Value, (float)ClickDelayMinBox.Value, (float)ClickDelayMaxBox.Value, (string)DelayTypeList.SelectedItem);
                ToggleCheckbox.Text = "Enabled";
                ToggleCheckbox.ForeColor = Color.Green;
            }
            else
            {
                Autoclick.StopClicking();
                ToggleCheckbox.Text = "Disabled";
                ToggleCheckbox.ForeColor = Color.WhiteSmoke;
            }
        }

        private void ClickDelayMinBox_ValueChanged(object sender, EventArgs e)
        {
            if (ClickDelayMinBox.Value > ClickDelayMaxBox.Value) return;
        }

        private void ClickDelayMaxBox_ValueChanged(object sender, EventArgs e)
        {
            if (ClickDelayMaxBox.Value < ClickDelayMinBox.Value) return;
        }

        private void DelayBox_ValueChanged(object sender, EventArgs e)
        {
            Autoclick.ACData.clickDelay = (float)DelayBox.Value;
        }

        private void DelayTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Autoclick.ACData.delayType = (string?)DelayTypeList.SelectedItem;
        }

        private void RandomDelayCB_CheckedChanged(object sender, EventArgs e)
        {
            ClickDelayMinBox.Enabled = RandomDelayCB.Checked;
            ClickDelayMaxBox.Enabled = RandomDelayCB.Checked;
        }
    }
}
