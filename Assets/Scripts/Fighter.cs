using UnityEngine;
using UnityEngine.Events;

public class Fighter : MonoBehaviour
{

    [SerializeField]

    private Health _health;

    [SerializeField]

    private Animator _characterAnimator;

    [SerializeField]

    private Attacks _attacks;

    [SerializeField]
    public Health Health => _health;

    public Attacks Attacks => _attacks;

    [SerializeField]

    private UnityEvent _onFighterInitialized;

    public Animator CharacterAnimator => _characterAnimator;

    public void InitializeFighter()
    {
        _onFighterInitialized?.Invoke();
    }
}
