/// Copyright (C) 2015 Kasper Kronborg Isager.
namespace Application.Foo

open System

/// <summary>Example type included for the purpose of demonstration.</summary>
type public Bar() =
  /// <summary>A thingy that can store a string.</summary>
  member val Thing = "" with get, set
  /// <summary>Write a message to the console.</summary>
  /// <param name="message">The message to write to the console.</param>
  member this.Baz(message : string) = Console.WriteLine message
