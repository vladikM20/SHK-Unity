using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        transform.Translate(direction * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out SpeedBooster booster))
        {
            StartCoroutine(ApplySpeedBooster(booster));
        }
    }

    private IEnumerator ApplySpeedBooster(SpeedBooster booster)
    {
        _speed *= booster.SpeedMultiplier;

        yield return new WaitForSeconds(booster.Duration);

        _speed /= booster.SpeedMultiplier;
    }
}
