using System;

using UnityEngine;

/// <summary>
/// Provides a disposable wrapper for a coroutine, allowing it to be stopped when disposed.
/// </summary>
public class CoroutineDisposable : IDisposable
{
    private readonly Coroutine _target;
    private readonly MonoBehaviour _parent;

    /// <summary>
    /// Initializes a new instance of the <see cref="CoroutineDisposable"/> class.
    /// </summary>
    /// <param name="target">The coroutine to be managed.</param>
    /// <param name="parent">The MonoBehaviour that started the coroutine.</param>
    public CoroutineDisposable(Coroutine target, MonoBehaviour parent)
    {
        _target = target;
        _parent = parent;
    }

    #region IDisposable Support
    private bool _disposedValue = false; // To detect redundant calls

    /// <summary>
    /// Releases the unmanaged resources used by the <see cref="CoroutineDisposable"/> and optionally releases the managed resources.
    /// </summary>
    /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
    protected virtual void Dispose(bool disposing)
    {
        if(!_disposedValue)
        {
            if(disposing)
            {
                // Stop the coroutine
                _parent.StopCoroutine(_target);
            }
            _disposedValue = true;
        }
    }

    /// <summary>
    /// Finalizes an instance of the <see cref="CoroutineDisposable"/> class.
    /// </summary>
    ~CoroutineDisposable()
    {
        Dispose(false);
    }

    /// <summary>
    /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    #endregion
}
