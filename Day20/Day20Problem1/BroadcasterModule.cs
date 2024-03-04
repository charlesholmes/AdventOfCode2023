﻿namespace Day20Problem1
{
    public class BroadcasterModule : Module
    {
        public override List<Pulse> HandlePulse(Pulse pulse)
        {
            var result = new List<Pulse>();
            foreach (Module destination in Destinations)
            {
                result.Add(new Pulse
                {
                    Source = this,
                    Destination = destination,
                    Type = pulse.Type
                });
            }

            return result;
        }
    }
}
