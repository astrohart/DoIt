using PostSharp.Patterns.Diagnostics;
using System;
using System.Threading;
using System.Windows.Forms;

namespace DoIt
{
    /// <summary>
    /// Methods for doing it.
    /// </summary>
    public class TheDoerOfIt
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static TheDoerOfIt() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected TheDoerOfIt() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:DoIt.TheDoerOfIt" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static TheDoerOfIt Instance { get; } = new TheDoerOfIt();

        /// <summary>
        /// Prompts the user if the user is sure. If the user says No, then
        /// stops. Otherwise, does it. A message is displayed when it has been
        /// done. "It" being a 5-second delay.
        /// </summary>
        public void DoIt()
        {
            if (!CanDoIt())
                return;

            for (var i = 0; i < 5; i++)
                Thread.Sleep(1000);

            Console.WriteLine("Did it!");

            MessageBox.Show(
                "It has been done!", Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );
        }

        /// <summary>
        /// Determines whether we can do it. Prompts the user with a Yes/No
        /// message box asking the user if the user is sure that we should do it.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the user says Yes, otherwise
        /// <see langword="false" />.
        /// </returns>
        protected bool CanDoIt()
            => DialogResult.Yes == MessageBox.Show(
                "Are you sure you want to do it?", Application.ProductName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2
            );
    }
}