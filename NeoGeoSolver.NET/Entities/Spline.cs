﻿using System.Numerics;
using NeoGeoSolver.NET.Solver;

namespace NeoGeoSolver.NET.Entities;

public class Spline : Entity {

	public Point[] p = new Point[4];

	public Spline()
	{
		for(var i = 0; i < p.Length; i++) {
			p[i] = new Point();
		}
	}

	public override EntityType type { get { return EntityType.Spline; } }
	public override IEnumerable<Expression> equations { get { yield break; } }

	public override ExpressionVector PointOn(Expression t) {
		var p0 = p[0].exp;
		var p1 = p[1].exp;
		var p2 = p[2].exp;
		var p3 = p[3].exp;
		var t2 = t * t;
		var t3 = t2 * t;
		return p1 * (3.0 * t3 - 6.0 * t2 + 3.0 * t) + p3 * t3 + p2 * (3.0 * t2 - 3.0 * t3) - p0 * (t3 - 3.0 * t2 + 3.0 * t - 1.0);
	}
}
