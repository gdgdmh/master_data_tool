using NUnit.Framework;

namespace NUnitTestProject
{
	public class TestCheckStringEmpty
	{
		[SetUp]
		public void Setup()
		{
		}

		/// <summary>
		/// 空文字列でtrueを返すか
		/// </summary>
		[Test]
		public void TestEmptyStringTrue()
		{
			MasterDataTool.CheckStringEmpty check = new MasterDataTool.CheckStringEmpty();
			string str = new string("");
			Assert.IsTrue(check.IsEmpty(str));
		}

		/// <summary>
		/// nullの文字列クラスでtrueを返すか
		/// </summary>
		[Test]
		public void TestNullTrue()
		{
			MasterDataTool.CheckStringEmpty check = new MasterDataTool.CheckStringEmpty();
			string str = null;
			Assert.IsTrue(check.IsEmpty(str));
		}

		/// <summary>
		/// 文字列Abcでfalseを返すか
		/// </summary>
		[Test]
		public void TestAbcFalse()
		{
			MasterDataTool.CheckStringEmpty check = new MasterDataTool.CheckStringEmpty();
			string str = new string("Abc");
			Assert.IsFalse(check.IsEmpty(str));
		}
	}
}