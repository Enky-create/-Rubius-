namespace StackTests
{
    public class StackTests
    {
        [Fact]
        public void Push_PushesObjectOntoStack()
        {
            // Arrange
            var stack = new Lesson6.Stack<int>();

            // Act
            stack.Push(1);

            // Assert
            Assert.False(stack.IsEmpty());
        }

        [Fact]
        public void Pop_PopsObjectFromStack()
        {
            // Arrange
            var stack = new Lesson6.Stack<int>();
            stack.Push(1);

            // Act
            var result = stack.Pop();

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Pop_ThrowsExceptionWhenStackIsEmpty()
        {
            // Arrange
            var stack = new Lesson6.Stack<int>();

            // Act & Assert
            Assert.Throws<Exception>(() => stack.Pop());
        }

        [Fact]
        public void Peek_ShowsNextObjectWithoutPoppingIt()
        {
            // Arrange
            var stack = new Lesson6.Stack<int>();
            stack.Push(1);
            stack.Push(2);

            // Act
            var result = stack.Peek();

            // Assert
            Assert.Equal(2, result);
            Assert.False(stack.IsEmpty()); // Assert the stack is not empty after Peek
        }

        [Fact]
        public void Peek_ThrowsExceptionWhenStackIsEmpty()
        {
            // Arrange
            var stack = new Lesson6.Stack<int>();

            // Act & Assert
            Assert.Throws<Exception>(() => stack.Peek());
        }

        [Fact]
        public void Clear_RemovesAllObjectsFromStack()
        {
            // Arrange
            var stack = new Lesson6.Stack<int>();
            stack.Push(1);
            stack.Push(2);

            // Act
            stack.Clear();

            // Assert
            Assert.True(stack.IsEmpty());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        public void IsEmpty_ReturnsTrueOnlyIfStackIsEmpty(int numberOfPushes)
        {
            // Arrange
            var stack = new Lesson6.Stack<int>();

            for (int i = 0; i < numberOfPushes; i++)
            {
                stack.Push(i);
            }

            // Act
            bool resultBeforeClear = stack.IsEmpty();
            stack.Clear();
            bool resultAfterClear = stack.IsEmpty();

            // Assert
            Assert.Equal(numberOfPushes == 0, resultBeforeClear);
            Assert.True(resultAfterClear);
        }
    }
}