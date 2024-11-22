using System.Collections.Generic;

namespace Unity.Mathematics {
	using Geometry;

	public static partial class math {
		// from https://en.wikipedia.org/wiki/M%C3%B6ller%E2%80%93Trumbore_intersection_algorithm

		/// <summary>
		/// Calculate the intersection point of a ray and triangle.
		/// </summary>
		/// <param name="ray">The ray used to intersect the <see paramref="triangle"/>.  The ray is assumed to be normalized.</param>
		/// <param name="triangle">The triangle to intersect.</param>
		/// <param name="distance">The distance along the ray where the triangle is intersected, only valid if the method returns <see langword="true"/>.</param>
		/// <returns><see langword="true"/> if the intersection succeeded and <see paramref="distance"/> is assigned; <see langword="false"/> otherwise.</returns>
		public static bool intersect(in Ray3D ray, in Triangle3D triangle, out float distance) {
			float EPSILON = 0.0000001f;
			float3 vertex0 = triangle.p0;
			float3 vertex1 = triangle.p1;
			float3 vertex2 = triangle.p2;

			float3 edge1 = vertex1 - vertex0;
			float3 edge2 = vertex2 - vertex0;

			float3 h = cross(ray.direction, edge2);
			float a = dot(edge1, h);

			if (abs(a) < EPSILON) {
				distance = float.NaN;
				return false; // This ray is parallel to this triangle.
			}

			float f = math.rcp(a);
			float3 s = ray.origin - vertex0;
			float u = f * dot(s, h);

			if (u < 0.0f || u > 1.0f) {
				distance = float.NaN;
				return false;
			}

			float3 q = cross(s, edge1);
			float v = f * dot(ray.direction, q);

			if (v < 0.0f || u + v > 1.0f) {
				distance = float.NaN;
				return false;
			}

			// At this stage we can compute t to find out where the intersection point is on the line.
			float t = f * dot(edge2, q);

			if (t > EPSILON) { // ray intersection
				distance = t;
				return true;
			} else { // This means that there is a line intersection but not a ray intersection.
				distance = float.NaN;
				return false;
			}
		}
	}
}