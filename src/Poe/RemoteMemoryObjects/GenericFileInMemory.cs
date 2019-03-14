namespace PoeHUD.Poe.RemoteMemoryObjects
{
	/// <summary>
	/// For debugging purposes
	/// </summary>
	public class GenericFileInMemory : RemoteMemoryObject
	{
		public override string ToString()
		{
			return $"FileAddr: {Address:x}";
		}
	}
}