using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    public WeaponDetailsScriptableObject weaponDetails;
    public int weaponListPosition;
    public float weaponReloadTimer;
    public int weaponClipRemainingAmmo;
    public int weaponRemainingAmmo;
    public bool isWeaponReloading;
}
