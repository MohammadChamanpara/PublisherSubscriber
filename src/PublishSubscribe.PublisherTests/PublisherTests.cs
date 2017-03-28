using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PublishSubscribe;
using PublishSubscribe.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace PublishSubscribe.Tests
{
    [TestClass()]
    public class PublisherTests
    {
        [TestMethod()]
        public void TransformMessage_WithAValidMessage_SetsTransformedToTrue()
        {
            //Arrange
            var publisher = new Publisher();
            var message = new Message();

            //Act
            publisher.TransformMessage(message);

            //Assert

            /* Using FluentAssertions */
            message.Transformed.Should().Be(true, 
                "TransformMessage should set the transformed value to true");

            /* Ususal Way */
            //Assert.AreEqual(true, message.Transformed);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TransformMessage_WithNullMessage_ThrowsArgumentNullException()
        {
            //Arrange
            var publisher = new Publisher();
            Message message = null;

            //Act
            publisher.TransformMessage(message);

            //Assert
            // The ExpectedException attribute takes care of it.

        }

        [TestMethod()]
        public void PublishMessage_WithAValidMessage_ChangesPublishTime()
        {
            //Arrange
            var publisher = new Publisher();
            var message = new Mock<Message>();

            //Act
            var lastPublishTime = publisher.LastPublishTime;
            publisher.Publish(message.Object);

            //Assert
            publisher.LastPublishTime.Should().NotBeOnOrBefore(lastPublishTime, 
                "Publish method should update the last publish time");
        }
    }
}