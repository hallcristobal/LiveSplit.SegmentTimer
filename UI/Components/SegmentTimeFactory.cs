using LiveSplit.Model;
using System;
using LiveSplit.UI.Components;

[assembly: ComponentFactory(typeof(SegmentTimeFactory))]
namespace LiveSplit.UI.Components
{
    public class SegmentTimeFactory : IComponentFactory
    {
        public string ComponentName => "Segment Timer";

        public string Description => "Displays the time of the current segment.";

        public ComponentCategory Category => ComponentCategory.Information;

        public IComponent Create(LiveSplitState state) => new SegmentTime(state);

        public string UpdateName => ComponentName;

        public string UpdateURL => "";

        public string XMLURL => "";

        public Version Version => Version.Parse("0.1.0");
    }
}
