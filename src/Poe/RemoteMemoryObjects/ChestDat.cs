namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class ChestDat : RemoteMemoryObject
	{
	    public string Key => M.ReadStringU(M.ReadLong(Address));

	    #region Overrides of Object

	    public override string ToString()
	    {
	        return Key;
	    }

	    #endregion
	}
}
