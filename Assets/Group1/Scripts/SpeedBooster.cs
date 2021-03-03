using UnityEngine;

public class SpeedBooster : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _speedMultiplier;

    public float Duration => _duration;
    public float SpeedMultiplier => _speedMultiplier;
}
