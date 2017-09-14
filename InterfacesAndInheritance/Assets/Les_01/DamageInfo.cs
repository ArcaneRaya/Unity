//using UnityEngine;

//public class DamageInfo 
//{
//    public int amount;
//}

//public class Entity : MonoBehaviour, IDamagable 
//{
//    protected int health;

//    public void OnDeath(){
        
//    }

//    public bool TakeDamage(IDamager dmgr){
//        return false;
//    }

//    protected void Die (){
//    }
//}

//public class ExplosiveBarrel : Entity, IDamager 
//{
//    public DamageInfo damageInfo{
//        get {
//            return dmgInfo;
//        }
//    }

//    private DamageInfo dmgInfo;

//    new protected void Die () {
        
//    }
//}

//public class Gun : IDamager
//{
//    public DamageInfo damageInfo
//    {
//        get
//        {
//            return dmgInfo;
//        }
//    }

//    private DamageInfo dmgInfo;

//    public void Fire(){
        
//    }
//}

//public class Player {
//    public Gun gun;

//    protected void HandleWeapons (){
        
//    }
//}