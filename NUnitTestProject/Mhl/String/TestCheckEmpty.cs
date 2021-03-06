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
		/// 空文字列でtrueを返すか
		/// </summary>
		[Test]
		public void TestEmptyStringTrue()
		{
			global::Mhl.String.CheckEmpty check = new global::Mhl.String.CheckEmpty();
			string str = new string("");
			Assert.IsTrue(check.IsEmpty(str));
		}

		/// <summary>
		/// nullの文字列クラスでtrueを返すか
		/// </summary>
		[Test]
		public void TestNullTrue()
		{
			global::Mhl.String.CheckEmpty check = new global::Mhl.String.CheckEmpty();
			string str = null;
			Assert.IsTrue(check.IsEmpty(str));
		}

		/// <summary>
		/// 文字列Abcでfalseを返すか
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