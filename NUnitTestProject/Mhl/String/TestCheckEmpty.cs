using NUnit.Framework;

namespace NUnitTestProject.Mhl.String
{
	public class TestCheckEmpty
	{
		[SetUp]
		public void Setup()
		{
		}

		/// <summary>
		/// ‹ó•¶Žš—ñ‚Åtrue‚ð•Ô‚·‚©
		/// </summary>
		[Test]
		public void TestEmptyStringTrue()
		{
			global::Mhl.String.CheckEmpty check = new global::Mhl.String.CheckEmpty();
			string str = new string("");
			Assert.IsTrue(check.IsEmpty(str));
		}

		/// <summary>
		/// null‚Ì•¶Žš—ñƒNƒ‰ƒX‚Åtrue‚ð•Ô‚·‚©
		/// </summary>
		[Test]
		public void TestNullTrue()
		{
			global::Mhl.String.CheckEmpty check = new global::Mhl.String.CheckEmpty();
			string str = null;
			Assert.IsTrue(check.IsEmpty(str));
		}

		/// <summary>
		/// •¶Žš—ñAbc‚Åfalse‚ð•Ô‚·‚©
		/// </summary>
		[Test]
		public void TestAbcFalse()
		{
			global::Mhl.String.CheckEmpty check = new global::Mhl.String.CheckEmpty();
			string str = new string("Abc");
			Assert.IsFalse(check.IsEmpty(str));
		}
	}
}