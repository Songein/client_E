using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Actor.Skill
{
    public interface IHit
    {
        public void Hit(IHitted target);
    }
}
