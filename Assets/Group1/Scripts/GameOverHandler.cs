using System.Collections.Generic;
using UnityEngine;

public class GameOverHandler : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private List<Enemy> _enemies;

    private void OnEnable()
    {
        foreach (var enemy in _enemies)
        {
            enemy.Died += OnDied;
        }
    }

    private void OnDied(Enemy enemy)
    {
        enemy.Died -= OnDied;
        _enemies.Remove(enemy);

        if(_enemies.Count == 0)
        {
            _gameOverPanel.SetActive(true);
        }
    }
}
