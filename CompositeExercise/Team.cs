using System;
using System.Collections.Generic;

namespace CompositeExercise
{
    public class Team : Resource
    {
        private IList<Resource> _resources = new List<Resource>();

        public void Add(Resource resource)
        {
            _resources.Add(resource);
        }

        public override void Deploy()
        {
            foreach (var resource in _resources)
            {
                resource.Deploy();
            }
        }
    }
}
