using System;
using System.Collections.Generic;

namespace Chap7
{
    public class Moon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PlanetId { get; set; }
        public int Radius { get; set; }
        public int SemiMajorAxis { get; set; }
        public Nullable<int> DiscoveryYear { get; set; }
        public virtual Planet Planet { get; set; }
    }

    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float SemiMajorAxis { get; set; }
        public virtual ICollection<Moon> Moons { get; set; }
    }
}