using System;
using System.Collections.Generic;
using System.Text;
using LanguageExt;
using Lucene.Net.Support;

namespace DesignPatterns.StructuralPatterns.Flyweight
{
    public class ParticleFactory
    {
        //private static LanguageExt.HashMap<String, Particle> particles = new LanguageExt.HashMap<String, Particle>();
        private static Dictionary<string, Particle> particles = new Dictionary<string, Particle>();

        public static Particle getSmallParticle(String color)
        {
            String key = color + "SMALL";
            Particle p;
            if(particles.ContainsKey(key))
                p = particles[key];
            else
            {
                p = new SmallParticle();
                p.color = color;
                particles.Add(key, p);
                Console.WriteLine("creating key");
            }

            return p;
        }

        public static Particle getMediumParticle(string color)
        {
            throw new NotImplementedException();
        }

        public static Particle getBigParticle(string color)
        {
            throw new NotImplementedException();
        }
    }
}
