using PoeHUD.Framework;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.FilesInMemory
{
	/// <summary>
	/// For debugging purposes
	/// </summary>
	public class GenericFilesInMemory : UniversalFileWrapper<GenericFileInMemory>
	{
		public string FileName { get; set; }

		public GenericFilesInMemory(Memory m, string fileName, long address) : base(m, address)
		{
			FileName = fileName;
		}

		public override string ToString()
		{
			return FileName;
		}
	}
}