using Microsoft.Office.Interop.Outlook;
using Office.Contrib.RibbonFactory.Interfaces;

namespace Office.Outlook.Contrib.RibbonFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class OutlookViewContextProvider : IViewContextProvider
    {
        /// <summary>
        /// Gets the context for view.
        /// </summary>
        /// <param name="view">The view.</param>
        /// <returns></returns>
        public object GetContextForView(object view)
        {
            var inspector = view as Inspector;
            if (inspector != null)
                return inspector.CurrentItem;

            var explorer = view as Explorer;
            if (explorer != null)
                return explorer.CurrentFolder;

            return null;
        }
    }
}