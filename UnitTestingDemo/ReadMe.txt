
Overview of Unit Testing

Running unit tests is to check that the code written is working as expected.
It's called unit testing because the functionality of the program is broken into small testable 
individual units.

Test class requirements
The minimum requirements for a test class are:
The [TestClass] attribute is required on any class that contains unit test methods that is to be tested.
Each test method that you want Test Explorer to recognize must have the [TestMethod] attribute.

You can have other classes in a unit test project that do not have the [TestClass]
attribute, and you can have other methods in test classes that do not have the
[TestMethod] attribute. You can call these other classes and methods from your test methods.

Test method requirements
A test method must meet the following requirements:
It's decorated with the [TestMethod] attribute.
It returns void .
It cannot have parameters.


Now let's get started

Create a class called eWallet and add some methods that perform the transactions
See code in eWallet.cs

Now that we have methods we can test, create unit test projects and test methods. To do this, 
right-click anywhere in the class code and choose Create Unit Tests from the right-click menu.
Click OK to accept the defaults to create your unit tests. A unit test stubs (UnitTestingDemoTests) are created in 
a new unit test project for all the methods in the class.

Now write your tests

The AAA (Arrange, Act, Assert) pattern is a common way of writing unit tests for a method under test.
The Arrange section of a unit test method initializes objects and sets the value of
the data that is passed to the method under test.
The Act section invokes the method under test with the arranged parameters.
The Assert section verifies that the action of the method under test behaves as
expected. For .NET, methods in the Assert class are often used for verification.
See code in eWalletTests.cs


Run tests in Test Explorer

Choose Test on the Visual Studio menu, the click Run All Test

Note:

Determine the diff scenarios you want to test in a method

Name each testing method according to the method name, scenario we are testing and expected return value.
The naming convention follows 3 parts as mentioned seperated with underscore.
E.g Withdraw_WithValidAmount_UpdatesBalance, Withdraw_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange

public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
{

	//Arrange
	var reservation = new Reservation();

	//Act
	var result = reservation.CanBeCancelledBy(new User { IsAdmin = True });

	//Asset
	Assert.IsTrue(result)

}

public void CanBeCancelledBy_SameUserCancellation_ReturnsTrue()
{

	//Arrange
	var reservation = new Reservation();

	//Act
	var result = reservation.CanBeCancelledBy(new User { IsAdmin = True });

	//Asset
	Assert.IsTrue(result)

}


All test method should be public void


