# Pascal Case
for naming class record or struct like

public class DataService 
{}

public record PhysicalAddress(
  string Street,
  string City,
  string StateOrProvince
  string ZipCode);
  
  public struct ValueCoordinate
  {
  
  }
  
  Interface -> using I prefix like
  
  public interface IWorkerQueue
  {
  
  }
  
  # camelCase
  internal fields and prefix them with _
  
  for example
  
  public class DataService
  {
    private IWorkerQueque _workerQueue
  }
  
  working with static fields that are private or internal use s_ prefix
  and for thread static t_
  
  for example
  
  public class DataService
  {
    private static IWorkerQueue s_workerQueue;
    
    [ThreadStatic]
    private static TimeSpan t_timeSpan;
  }
  
  for method parameters:
  
  public T SomeMethod<T>(int someNumber, bool isValid)
  {
  }
  
  
 # snake_case
 Not used in C# but in python is widely used for
  naming any variables
  
  for example
  
  class User:
    props = {
    "first_name": "",
    "last_name": ""
  
  MAX_USERS = 10 /* Sreaming snake case on constants*/
  
  
  }
