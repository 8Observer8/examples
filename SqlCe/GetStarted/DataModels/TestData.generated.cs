//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/t4models).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;

using LinqToDB;
using LinqToDB.Mapping;

namespace DataModel
{
	/// <summary>
	/// Database       : TestData
	/// Data Source    : E:\Projects\Git\linq2db.examples\SqlCe\GetStarted\DataModels\..\TestData.sdf
	/// Server Version : 4.0.8876.1
	/// </summary>
	public partial class TestDataDB : LinqToDB.Data.DataConnection
	{
		public ITable<AllType>      AllTypes       { get { return this.GetTable<AllType>(); } }
		public ITable<Child>        Children       { get { return this.GetTable<Child>(); } }
		public ITable<DataType>     DataTypes      { get { return this.GetTable<DataType>(); } }
		public ITable<Doctor>       Doctors        { get { return this.GetTable<Doctor>(); } }
		public ITable<GrandChild>   GrandChilds    { get { return this.GetTable<GrandChild>(); } }
		public ITable<LinqDataType> LinqDataTypes  { get { return this.GetTable<LinqDataType>(); } }
		public ITable<Parent>       Parents        { get { return this.GetTable<Parent>(); } }
		public ITable<Patient>      Patients       { get { return this.GetTable<Patient>(); } }
		public ITable<Person>       People         { get { return this.GetTable<Person>(); } }
		public ITable<TestIdentity> TestIdentities { get { return this.GetTable<TestIdentity>(); } }

		public TestDataDB()
		{
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
		}
	}

	[Table("AllTypes")]
	public partial class AllType
	{
		[PrimaryKey, NotNull    ] public int       ID                       { get; set; } // int
		[Column,        Nullable] public long?     bigintDataType           { get; set; } // bigint
		[Column,        Nullable] public decimal?  numericDataType          { get; set; } // numeric
		[Column,        Nullable] public bool?     bitDataType              { get; set; } // bit
		[Column,        Nullable] public short?    smallintDataType         { get; set; } // smallint
		[Column,        Nullable] public decimal?  decimalDataType          { get; set; } // numeric
		[Column,        Nullable] public int?      intDataType              { get; set; } // int
		[Column,        Nullable] public sbyte?    tinyintDataType          { get; set; } // tinyint
		[Column,        Nullable] public decimal?  moneyDataType            { get; set; } // money
		[Column,        Nullable] public double?   floatDataType            { get; set; } // float
		[Column,        Nullable] public float?    realDataType             { get; set; } // real
		[Column,        Nullable] public DateTime? datetimeDataType         { get; set; } // datetime
		[Column,        Nullable] public string    ncharDataType            { get; set; } // nchar(20)
		[Column,        Nullable] public string    nvarcharDataType         { get; set; } // nvarchar(20)
		[Column,        Nullable] public string    ntextDataType            { get; set; } // ntext
		[Column,        Nullable] public byte[]    binaryDataType           { get; set; } // binary(1)
		[Column,        Nullable] public byte[]    varbinaryDataType        { get; set; } // varbinary(1)
		[Column,        Nullable] public byte[]    imageDataType            { get; set; } // image
		[Column,        Nullable] public byte[]    timestampDataType        { get; set; } // rowversion
		[Column,        Nullable] public Guid?     uniqueidentifierDataType { get; set; } // uniqueidentifier
	}

	[Table("Child")]
	public partial class Child
	{
		[Column, Nullable] public int? ParentID { get; set; } // int
		[Column, Nullable] public int? ChildID  { get; set; } // int
	}

	[Table("DataTypes")]
	public partial class DataType
	{
		[Column, Nullable] public int?     ID         { get; set; } // int
		[Column, Nullable] public decimal? MoneyValue { get; set; } // numeric(10, 4)
	}

	[Table("Doctor")]
	public partial class Doctor
	{
		[PrimaryKey, NotNull] public int    PersonID { get; set; } // int
		[Column,     NotNull] public string Taxonomy { get; set; } // nvarchar(50)
	}

	[Table("GrandChild")]
	public partial class GrandChild
	{
		[Column, Nullable] public int? ParentID     { get; set; } // int
		[Column, Nullable] public int? ChildID      { get; set; } // int
		[Column, Nullable] public int? GrandChildID { get; set; } // int
	}

	[Table("LinqDataTypes")]
	public partial class LinqDataType
	{
		[Column, Nullable] public int?      ID             { get; set; } // int
		[Column, Nullable] public decimal?  MoneyValue     { get; set; } // numeric(10, 4)
		[Column, Nullable] public DateTime? DateTimeValue  { get; set; } // datetime
		[Column, Nullable] public DateTime? DateTimeValue2 { get; set; } // datetime
		[Column, Nullable] public bool?     BoolValue      { get; set; } // bit
		[Column, Nullable] public Guid?     GuidValue      { get; set; } // uniqueidentifier
		[Column, Nullable] public byte[]    BinaryValue    { get; set; } // varbinary(5000)
		[Column, Nullable] public short?    SmallIntValue  { get; set; } // smallint
		[Column, Nullable] public int?      IntValue       { get; set; } // int
		[Column, Nullable] public long?     BigIntValue    { get; set; } // bigint
	}

	[Table("Parent")]
	public partial class Parent
	{
		[Column, Nullable] public int? ParentID { get; set; } // int
		[Column, Nullable] public int? Value1   { get; set; } // int
	}

	[Table("Patient")]
	public partial class Patient
	{
		[PrimaryKey, NotNull] public int    PersonID  { get; set; } // int
		[Column,     NotNull] public string Diagnosis { get; set; } // nvarchar(256)
	}

	[Table("Person")]
	public partial class Person
	{
		[PrimaryKey, NotNull    ] public int    PersonID   { get; set; } // int
		[Column,     NotNull    ] public string FirstName  { get; set; } // nvarchar(50)
		[Column,     NotNull    ] public string LastName   { get; set; } // nvarchar(50)
		[Column,        Nullable] public string MiddleName { get; set; } // nvarchar(50)
		[Column,     NotNull    ] public char   Gender     { get; set; } // nchar(1)
	}

	[Table("TestIdentity")]
	public partial class TestIdentity
	{
		[PrimaryKey, NotNull] public int ID { get; set; } // int
	}
}
