using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGraph
{
    public class AppState
    {
        public MetaTags MetaTags { get; private set; } = new MetaTags();

        public event Action? OnChange;

        public void SetMetaTags(MetaTags metatags)
        {
            MetaTags = metatags;
            NotifyStateChanged();
        }

        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}
