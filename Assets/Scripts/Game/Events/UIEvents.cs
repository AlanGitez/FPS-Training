using UnityEngine.Events;

[System.Serializable]
public class OnInventorySwitch : UnityEvent<bool> { }

[System.Serializable]
public class OnShootUpdateUIEvent : UnityEvent<ShootData> { }