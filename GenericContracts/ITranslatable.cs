namespace GenericContracts;

/// <summary>
/// Common pattern on implementation is to have the single input method new up the out object and then call the two input method.
/// </summary>
/// <typeparam name="TIn">Specified Object Input</typeparam>
/// <typeparam name="TOut">Expected Object Output</typeparam>
public interface ITranslatable<TOut,in TIn>
{
    /// <summary>
    /// Translates the Input Parameter Object to the Expected Object Output
    /// </summary>
    /// <param name="input">Specified Object Input</param>
    /// <returns>Expected Object Output</returns>
    TOut Translate(TIn input);

    /// <summary>
    /// Translates the Input Parameter Object and overwrites the Existing Expected Object Output
    /// </summary>
    /// <param name="existing">Existing Expected Object Output</param>
    /// <param name="input">Specified Object Input</param>
    /// <returns>Expected Object Output</returns>
    TOut Translate(TOut existing, TIn input);
}