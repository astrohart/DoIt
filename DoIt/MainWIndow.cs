using PostSharp.Patterns.Diagnostics;
using System.Windows.Forms;

namespace DoIt
{
    /// <summary>
    /// Main window of the application.
    /// </summary>
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static MainWindow() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:DoIt.MainWindow"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static MainWindow Instance { get; } = new MainWindow();

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Forms.Control.Click"/> event
        /// raised by the Do It button.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// A <see cref="T:System.EventArgs"/> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by executing the actions specified by the <see
        /// cref="M:DoIt.TheDoerOfIt.DoIt"/> method.
        /// </remarks>
        private void OnClickDoItButton(object sender, System.EventArgs e)
            => TheDoerOfIt.Instance.DoIt();
    }
}