using System;
using UnityEngine;

namespace AmarilisLib
{
    /// <summary>
    /// Provides a disposable wrapper for a GameObject, allowing it to be destroyed when disposed.
    /// </summary>
    public class GameObjectDisposable : IDisposable
    {
        /// <summary>
        /// The GameObject to be managed.
        /// </summary>
        public readonly GameObject _target;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameObjectDisposable"/> class.
        /// </summary>
        /// <param name="go">The GameObject to be managed.</param>
        public GameObjectDisposable(GameObject go)
        {
            _target = go;
        }

        #region IDisposable Support
        private bool _disposedValue = false; // To detect redundant calls

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="GameObjectDisposable"/> and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if(!_disposedValue)
            {
                if(disposing)
                {
                    GameObject.Destroy(_target);
                }
                _disposedValue = true;
            }
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="GameObjectDisposable"/> class.
        /// </summary>
        ~GameObjectDisposable()
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
}
