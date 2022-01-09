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
		/// �󕶎����true��Ԃ���
		/// </summary>
		[Test]
		public void TestEmptyStringTrue()
		{
			MasterDataTool.CheckStringEmpty check = new MasterDataTool.CheckStringEmpty();
			string str = new string("");
			Assert.IsTrue(check.IsEmpty(str));
		}

		/// <summary>
		/// null�̕�����N���X��true��Ԃ���
		/// </summary>
		[Test]
		public void TestNullTrue()
		{
			MasterDataTool.CheckStringEmpty check = new MasterDataTool.CheckStringEmpty();
			string str = null;
			Assert.IsTrue(check.IsEmpty(str));
		}

		/// <summary>
		/// ������Abc��false��Ԃ���
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