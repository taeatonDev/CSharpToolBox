namespace GenericContracts;
//Note: Do not extend this file with additional extension.
//If you need more than 7 inputs, please consider using a object containing the inputs you need as a request object.

/// <summary>
/// Get the first applicable object based on the input parameter.
/// If no matching object return null.
/// Do not use exception logic to return a null like concept from the data source.
/// </summary>
/// <typeparam name="TOut">Expected Object Output</typeparam>
/// <typeparam name="TIn0">Specified Object Input</typeparam>
public interface IRetrieve<out TOut, in TIn0>
{
    TOut GetFirst(TIn0 input0);
}

/// <summary>
/// Get the first applicable object based on the input parameter.
/// If no matching object return null.
/// Do not use exception logic to return a null like concept from the data source.
/// </summary>
/// <typeparam name="TOut">Expected Object Output</typeparam>
/// <typeparam name="TIn0">Specified Object Input</typeparam>
/// <typeparam name="TIn1">Specified Object Input</typeparam>
public interface IRetrieve<out TOut, in TIn0, in TIn1>
{
    TOut GetFirst(TIn0 input0, TIn1 input1);
}

/// <summary>
/// Get the first applicable object based on the input parameter.
/// If no matching object return null.
/// Do not use exception logic to return a null like concept from the data source.
/// </summary>
/// <typeparam name="TOut">Expected Object Output</typeparam>
/// <typeparam name="TIn0">Specified Object Input</typeparam>
/// <typeparam name="TIn1">Specified Object Input</typeparam>
/// <typeparam name="TIn2">Specified Object Input</typeparam>
public interface IRetrieve<out TOut, in TIn0, in TIn1, in TIn2>
{
    TOut GetFirst(TIn0 input0, TIn1 input1, TIn2 input2);
}

/// <summary>
/// Get the first applicable object based on the input parameter.
/// If no matching object return null.
/// Do not use exception logic to return a null like concept from the data source.
/// </summary>
/// <typeparam name="TOut">Expected Object Output</typeparam>
/// <typeparam name="TIn0">Specified Object Input</typeparam>
/// <typeparam name="TIn1">Specified Object Input</typeparam>
/// <typeparam name="TIn2">Specified Object Input</typeparam>
/// <typeparam name="TIn3">Specified Object Input</typeparam>
public interface IRetrieve<out TOut, in TIn0, in TIn1, in TIn2, in TIn3>
{
    TOut GetFirst(TIn0 input0, TIn1 input1, TIn2 input2, TIn3 input3);
}

/// <summary>
/// Get the first applicable object based on the input parameter.
/// If no matching object return null.
/// Do not use exception logic to return a null like concept from the data source.
/// </summary>
/// <typeparam name="TOut">Expected Object Output</typeparam>
/// <typeparam name="TIn0">Specified Object Input</typeparam>
/// <typeparam name="TIn1">Specified Object Input</typeparam>
/// <typeparam name="TIn2">Specified Object Input</typeparam>
/// <typeparam name="TIn3">Specified Object Input</typeparam>
/// <typeparam name="TIn4">Specified Object Input</typeparam>
public interface IRetrieve<out TOut, in TIn0, in TIn1, in TIn2, in TIn3, in TIn4>
{
    TOut GetFirst(TIn0 input0, TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4);
}

/// <summary>
/// Get the first applicable object based on the input parameter.
/// If no matching object return null.
/// Do not use exception logic to return a null like concept from the data source.
/// </summary>
/// <typeparam name="TOut">Expected Object Output</typeparam>
/// <typeparam name="TIn0">Specified Object Input</typeparam>
/// <typeparam name="TIn1">Specified Object Input</typeparam>
/// <typeparam name="TIn2">Specified Object Input</typeparam>
/// <typeparam name="TIn3">Specified Object Input</typeparam>
/// <typeparam name="TIn4">Specified Object Input</typeparam>
/// <typeparam name="TIn5">Specified Object Input</typeparam>
public interface IRetrieve<out TOut, in TIn0, in TIn1, in TIn2, in TIn3, in TIn4, in TIn5>
{
    TOut GetFirst(TIn0 input0, TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5);
}

/// <summary>
/// Get the first applicable object based on the input parameter.
/// If no matching object return null.
/// Do not use exception logic to return a null like concept from the data source.
/// </summary>
/// <typeparam name="TOut">Expected Object Output</typeparam>
/// <typeparam name="TIn0">Specified Object Input</typeparam>
/// <typeparam name="TIn1">Specified Object Input</typeparam>
/// <typeparam name="TIn2">Specified Object Input</typeparam>
/// <typeparam name="TIn3">Specified Object Input</typeparam>
/// <typeparam name="TIn4">Specified Object Input</typeparam>
/// <typeparam name="TIn5">Specified Object Input</typeparam>
/// <typeparam name="TIn6">Specified Object Input</typeparam>
public interface IRetrieve<out TOut, in TIn0, in TIn1, in TIn2, in TIn3, in TIn4, in TIn5, in TIn6>
{
    TOut GetFirst(TIn0 input0, TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5, TIn6 input6);
}