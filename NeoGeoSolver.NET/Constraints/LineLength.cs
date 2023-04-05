﻿using NeoGeoSolver.NET.Entities;

using NeoGeoSolver.NET.Solver;

namespace NeoGeoSolver.NET.Constraints;

public class LineLength : Value {
  private readonly Line _line;
	public LineLength(Line line)
	{
		_line = line;
		Satisfy();
	}

	public override IEnumerable<Expression> equations {
		get {
			yield return _line.Length() - value;
		}
	}
}