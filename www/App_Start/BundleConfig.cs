using System.Web.Optimization;

namespace www
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection Bundles)
        {
            Bundles.Add(new StyleBundle("~/Styles").Include(
                "~/Style/comingsoon.min.css"));
        }
    }
}
