using System.Diagnostics;
using System.Windows.Forms;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using FlaUI.UIA3;

public class Class1
{
	public Class1()
	{

        public void Closed()
        {
            var msg = Task.Factory.StartNew(() =>
            {
                MessageBox.Show("test", "title", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            });

            await Task.Factory.StartNew(() =>
            {
                var automation = new UIA3Automation();
                var desk = automation.GetDesktop();
                var msg = desk.FindFirstChild(cf => cf.ByProcessId(Process.GetCurrentProcess().Id).And(cf.ByControlType(ControlType.Window)));

                // Variant 2 with invoking the button
                var button = msg.FindFirstChild(cf => cf.ByName("Ja")).AsButton();
                button.Invoke();
            });
            await msg;
        }
        
    }
}
