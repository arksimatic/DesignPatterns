using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.ObjectPool
{
    public static class Pool
    {
        private static List<SomeObject> _available = new List<SomeObject>();
        private static List<SomeObject> _inUse = new List<SomeObject>();

        public static SomeObject GetObject()
        {
            lock (_available) //lock lockes the object and do not let other threads use it until release
            {
                if (_available.Count != 0)
                {
                    SomeObject po = _available[0];
                    _inUse.Add(po);
                    _available.RemoveAt(0);
                    return po;
                }
                else
                {
                    SomeObject po = new SomeObject();
                    _inUse.Add(po);
                    return po;
                }
            }
        }

        public static void ReleaseObject(SomeObject po)
        {
            CleanUp(po);

            lock (_available)
            {
                _available.Add(po);
                _inUse.Remove(po);
            }
        }

        private static void CleanUp(SomeObject po)
        {
            //some cleanup
        }
    }
}
