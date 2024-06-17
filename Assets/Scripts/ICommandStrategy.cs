using UnityEngine;

namespace com.Ayden.interfaces
{
    public interface ICommandStrategy
    {
        Command CreateCommand(Vector3 position);
    }
}