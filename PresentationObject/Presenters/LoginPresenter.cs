using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinForms.Views;

namespace WinForms.Presenters
{
    /// <summary>
    /// Login Presenter class.
    /// </summary>
    /// <remarks>
    /// MV Patterns: MVP design pattern.
    /// </remarks>
    public class LoginPresenter : Presenter<ILoginView>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="view">The view</param>
        public LoginPresenter(ILoginView view)
            : base(view)
        {
        }

        /// <summary>
        /// Perform login. Gets data from view and calls model.
        /// </summary>
        public bool Login(string username, string password)
        {
            username = View.Username;
            password = View.Password;

            return Model.Login(username, password);
        }
    }
}
