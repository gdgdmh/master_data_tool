using NUnit.Framework;

namespace NUnitTestProject.Mhl.String
{
	public class TestCheckStringEmpty
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
			global::Mhl.String.CheckStringEmpty check = new global::Mhl.String.CheckStringEmpty();
			string str = new string("");
			Assert.IsTrue(check.IsEmpty(str));
		}

		/// <summary>
		/// null‚Ì•¶Žš—ñƒNƒ‰ƒX‚Åtrue‚ð•Ô‚·‚©
		/// </summary>
		[Test]
		public void TestNullTrue()
		{
			global::Mhl.String.CheckStringEmpty check = new global::Mhl.String.CheckStringEmpty();
			string str = null;
			Assert.IsTrue(check.IsEmpty(str));
		}

		/// <summary>
		/// •¶Žš—ñAbc‚Åfalse‚ð•Ô‚·‚©
		/// </summary>
		[Test]
		public void TestAbcFalse()
		{
			global::Mhl.String.CheckStringEmpty check = new global::Mhl.String.CheckStringEmpty();
			string str = new string("Abc");
			Assert.IsFalse(check.IsEmpty(str));
		}
	}
}