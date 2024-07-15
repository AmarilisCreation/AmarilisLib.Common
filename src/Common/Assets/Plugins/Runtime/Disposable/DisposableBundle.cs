using System.Collections.Generic;

using System;

/// <summary>
/// Represents a bundle of disposable objects that can be disposed together.
/// </summary>
public class DisposableBundle : IDisposable
{
    private readonly List<IDisposable> _list = new List<IDisposable>();

    /// <summary>
    /// Adds one or more disposable objects to the bundle.
    /// </summary>
    /// <param name="disposables">The disposable objects to add.</param>
    public void Add(params IDisposable[] disposables)
    {
        foreach(var d in disposables)
        {
            _list.Add(d);
        }
    }

    #region IDisposable Support
    private bool _disposedValue = false; // To detect redundant calls

    /// <summary>
    /// Releases the unmanaged resources used by the <see cref="DisposableBundle"/> and optionally releases the managed resources.
    /// </summary>
    /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
    protected virtual void Dispose(bool disposing)
    {
        if(!_disposedValue)
        {
            if(disposing)
            {
                _list.ForEach(d => d.Dispose());
            }
            _disposedValue = true;
        }
    }

    /// <summary>
    /// Finalizes an instance of the <see cref="DisposableBundle"/> class.
    /// </summary>
    ~DisposableBundle()
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