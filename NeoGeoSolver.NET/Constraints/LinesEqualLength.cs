﻿using NeoGeoSolver.NET.Entities;
using NeoGeoSolver.NET.Solver;

namespace NeoGeoSolver.NET.Constraints;

public class LinesEqualLength : Value
{
  private readonly Line _l0;
  private readonly Line _l1;

  public LinesEqualLength(Line l0, Line l1)
  {
    _l0 = l0;
    _l1 = l1;
    value.value = 1.0;
  }

  public override IEnumerable<Expression> equations
  {
    get
    {
      yield return _l0.Length() - _l1.Length() * value;
    }
  }
}