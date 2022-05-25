namespace GenericContracts;
//Note: Do not extend this file with additional extension.
//If you need more than 7 inputs, please consider using a object containing the inputs you need as a request object.

/// <summary>
/// Get all applicable object based on the input parameter.
/// Should always return an IEnumberable of the specified object type
/// If source contains no objects to return, still return the IEnumberable with an empty collection.
/// Should never return null.
/// Do not use exception logic to return a null like concept from the data source.
/// </summary>
/// <typeparam name="TOut">Expected Object Output</typeparam>
/// <typeparam name="TIn0">Specified Object Input</typeparam>
public interface IBulkRetrieve<out TOut, in TIn0>
{
    IEnumerable<TOut> GetAll(TIn0 input0);
}

/// <summary>
/// Get all applicable object based on the input parameter.
/// Should always return an IEnumberable of the specified object type
/// If source contains no objects to return, still return the IEnumberable with an empty collection.
/// Should never return null.
/// Do not use exception logic to return a null like concept from the data source.
/// </summary>
/// <typeparam name="TOut">Expected Object Output</typeparam>
/// <typeparam name="TIn0">Specified Object Input</typeparam>
/// <typeparam name="TIn1">Specified Object Input</typeparam>
public interface IBulkRetrieve<out TOut, in TIn0, in TIn1>
{
    IEnumerable<TOut> GetAll(TIn0 input0, TIn1 input1);
}

/// <summary>
/// Get all applicable object based on the input parameter.
/// Should always return an IEnumberable of the specified object type
/// If source contains no objects to return, still return the IEnumberable with an empty collection.
/// Should never return null.
/// Do not use exception logic to return a null like concept from the data source.
/// </summary>
/// <typeparam name="TOut">Expected Object Output</typeparam>
/// <typeparam name="TIn0">Specified Object Input</typeparam>
/// <typeparam name="TIn1">Specified Object Input</typeparam>
/// <typeparam name="TIn2">Specified Object Input</typeparam>
public interface IBulkRetrieve<out TOut, in TIn0, in TIn1, in TIn2>
{
    IEnumerable<TOut> GetAll(TIn0 input0, TIn1 input1, TIn2 input2);
}

/// <summary>
/// Get all applicable object based on the input parameter.
/// Should always return an IEnumberable of the specified object type
/// If source contains no objects to return, still return the IEnumberable with an empty collection.
/// Should never return null.
/// Do not use exception logic to return a null like concept from the data source.
/// </summary>
/// <typeparam name="TOut">Expected Object Output</typeparam>
/// <typeparam name="TIn0">Specified Object Input</typeparam>
/// <typeparam name="TIn1">Specified Object Input</typeparam>
/// <typeparam name="TIn2">Specified Object Input</typeparam>
/// <typeparam name="TIn3">Specified Object Input</typeparam>
public interface IBulkRetrieve<out TOut, in TIn0, in TIn1, in TIn2, in TIn3>
{
    IEnumerable<TOut> GetAll(TIn0 input0, TIn1 input1, TIn2 input2, TIn3 input3);
}

/// <summary>
/// Get all applicable object based on the input parameter.
/// Should always return an IEnumberable of the specified object type
/// If source contains no objects to return, still return the IEnumberable with an empty collection.
/// Should never return null.
/// Do not use exception logic to return a null like concept from the data source.
/// </summary>
/// <typeparam name="TOut">Expected Object Output</typeparam>
/// <typeparam name="TIn0">Specified Object Input</typeparam>
/// <typeparam name="TIn1">Specified Object Input</typeparam>
/// <typeparam name="TIn2">Specified Object Input</typeparam>
/// <typeparam name="TIn3">Specified Object Input</typeparam>
/// <typeparam name="TIn4">Specified Object Input</typeparam>
public interface IBulkRetrieve<out TOut, in TIn0, in TIn1, in TIn2, in TIn3, in TIn4>
{
    IEnumerable<TOut> GetAll(TIn0 input0, TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4);
}

/// <summary>
/// Get all applicable object based on the input parameter.
/// Should always return an IEnumberable of the specified object type
/// If source contains no objects to return, still return the IEnumberable with an empty collection.
/// Should never return null.
/// Do not use exception logic to return a null like concept from the data source.
/// </summary>
/// <typeparam name="TOut">Expected Object Output</typeparam>
/// <typeparam name="TIn0">Specified Object Input</typeparam>
/// <typeparam name="TIn1">Specified Object Input</typeparam>
/// <typeparam name="TIn2">Specified Object Input</typeparam>
/// <typeparam name="TIn3">Specified Object Input</typeparam>
/// <typeparam name="TIn4">Specified Object Input</typeparam>
/// <typeparam name="TIn5">Specified Object Input</typeparam>
public interface IBulkRetrieve<out TOut, in TIn0, in TIn1, in TIn2, in TIn3, in TIn4, in TIn5>
{
    IEnumerable<TOut> GetAll(TIn0 input0, TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5);
}

/// <summary>
/// Get all applicable object based on the input parameter.
/// Should always return an IEnumberable of the specified object type
/// If source contains no objects to return, still return the IEnumberable with an empty collection.
/// Should never return null.
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
public interface IBulkRetrieve<out TOut, in TIn0, in TIn1, in TIn2, in TIn3, in TIn4, in TIn5, in TIn6>
{
    IEnumerable<TOut> GetAll(TIn0 input0, TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5, TIn6 input6);
}