namespace Marcware.RandomBookmarkReader.GeneralClasses
{
    /// <summary>
    /// Class returning details of running a process
    /// </summary>
    /// <typeparam name="T">Type of the result</typeparam>
    internal class ProcessResult<T>
    {
        /// <summary>
        /// Was the process successful?
        /// </summary>
        public bool Success { get; set; } = true;

        /// <summary>
        /// Details of the error that has occurred
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Result of running the process
        /// </summary>
        public T Result { get; set; }
    }
}
