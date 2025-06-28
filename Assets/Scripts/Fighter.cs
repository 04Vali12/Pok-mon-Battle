using System;
using UnityEngine;
using UnityEngine.Events;

public class Fighter : MonoBehaviour
{
    [SerializeField]
    private string _name;

    public string Name => _name;

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

    [SerializeField]
    private string _winAnimationName = "Win";

    [SerializeField]
    private string _winSoundName  = "WinSound";

    public string WinSoundName => _winSoundName;
    public string WinAnimationName => _winAnimationName;

    public Animator CharacterAnimator => _characterAnimator;

    public void InitializeFighter()
    {
        _onFighterInitialized?.Invoke();
    }
}
