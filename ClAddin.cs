using System.Windows.Forms;
using Autodesk.Navisworks.Api.Plugins;

namespace AddinRibbon
{

    [Plugin("AddinRibbon", "CONN", DisplayName = "AddinRibbon")]
    [RibbonLayout("AddinRibbon.xaml")]
    [RibbonTab("ID_CustomTab_1")]
    [Command("ID_Button_1", ToolTip = "Show a message")]

    public class ClAddin : CommandHandlerPlugin
    {
        public override int ExecuteCommand(string name, params string[] parameters)
        {

            switch (name)
            {
                case "ID_Button_1":
                    MessageBox.Show("ID_Button_1");
                    break;
            }


            return 0;
        }
    }

}
