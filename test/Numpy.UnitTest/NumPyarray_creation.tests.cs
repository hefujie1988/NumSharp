﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
//using Python.Runtime;
//using Python.Included;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numpy.Models;
using Assert = NUnit.Framework.Assert;

namespace Numpy.UnitTest
{
    [TestClass]
    public class NumPyarray_creationTest : BaseTestCase
    {
        [TestMethod]
        public void emptyTest()
        {
            var given = np.empty(new Shape(2, 2), np.int32);
            Assert.IsTrue(given.repr.StartsWith("array([["));
            Assert.IsTrue(given.repr.EndsWith("]])"));
        }

        [TestMethod]
        public void empty_likeTest()
        {
            var a = new[,] {{1, 2, 3}, {4, 5, 6}};
            var given=  np.empty_like(a);
            Assert.AreEqual(new Shape(2,3), given.shape );
            Assert.AreEqual(np.int32, given.dtype);

            var b = np.array(new[,]{{1f, 2f, 3f},{4f,5f,6f} });
            var c =  np.empty_like(b);
            Assert.AreEqual(new Shape(2, 3), c.shape);
            Assert.AreEqual(np.float32, c.dtype);
        }

        [TestMethod]
        public void eyeTest()
        {
            // >>> np.eye(2, dtype=int)
            // array([[1, 0],
            //        [0, 1]])
            // >>> np.eye(3, k=1)
            // array([[ 0.,  1.,  0.],
            //        [ 0.,  0.,  1.],
            //        [ 0.,  0.,  0.]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.eye(2, dtype=int);
            expected=
                "array([[1, 0],\n" +
                "       [0, 1]])";
            Assert.AreEqual(expected, given.repr);
            given=  np.eye(3, k=1);
            expected=
                "array([[ 0.,  1.,  0.],\n" +
                "       [ 0.,  0.,  1.],\n" +
                "       [ 0.,  0.,  0.]])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void identityTest()
        {
            // >>> np.identity(3)
            // array([[ 1.,  0.,  0.],
            //        [ 0.,  1.,  0.],
            //        [ 0.,  0.,  1.]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.identity(3);
            expected=
                "array([[ 1.,  0.,  0.],\n" +
                "       [ 0.,  1.,  0.],\n" +
                "       [ 0.,  0.,  1.]])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void onesTest()
        {
            // >>> np.ones(5)
            // array([ 1.,  1.,  1.,  1.,  1.])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.ones(5);
            expected=
                "array([ 1.,  1.,  1.,  1.,  1.])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.ones((5,), dtype=int)
            // array([1, 1, 1, 1, 1])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.ones((5,), dtype=int);
            expected=
                "array([1, 1, 1, 1, 1])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.ones((2, 1))
            // array([[ 1.],
            //        [ 1.]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.ones((2, 1));
            expected=
                "array([[ 1.],\n" +
                "       [ 1.]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> s = (2,2)
            // >>> np.ones(s)
            // array([[ 1.,  1.],
            //        [ 1.,  1.]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  s = (2,2);
            given=  np.ones(s);
            expected=
                "array([[ 1.,  1.],\n" +
                "       [ 1.,  1.]])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void ones_likeTest()
        {
            // >>> x = np.arange(6)
            // >>> x = x.reshape((2, 3))
            // >>> x
            // array([[0, 1, 2],
            //        [3, 4, 5]])
            // >>> np.ones_like(x)
            // array([[1, 1, 1],
            //        [1, 1, 1]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  x = np.arange(6);
            given=  x = x.reshape((2, 3));
            given=  x;
            expected=
                "array([[0, 1, 2],\n" +
                "       [3, 4, 5]])";
            Assert.AreEqual(expected, given.repr);
            given=  np.ones_like(x);
            expected=
                "array([[1, 1, 1],\n" +
                "       [1, 1, 1]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> y = np.arange(3, dtype=float)
            // >>> y
            // array([ 0.,  1.,  2.])
            // >>> np.ones_like(y)
            // array([ 1.,  1.,  1.])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  y = np.arange(3, dtype=float);
            given=  y;
            expected=
                "array([ 0.,  1.,  2.])";
            Assert.AreEqual(expected, given.repr);
            given=  np.ones_like(y);
            expected=
                "array([ 1.,  1.,  1.])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void zerosTest()
        {
            // >>> np.zeros(5)
            // array([ 0.,  0.,  0.,  0.,  0.])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.zeros(5);
            expected=
                "array([ 0.,  0.,  0.,  0.,  0.])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.zeros((5,), dtype=int)
            // array([0, 0, 0, 0, 0])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.zeros((5,), dtype=int);
            expected=
                "array([0, 0, 0, 0, 0])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.zeros((2, 1))
            // array([[ 0.],
            //        [ 0.]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.zeros((2, 1));
            expected=
                "array([[ 0.],\n" +
                "       [ 0.]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> s = (2,2)
            // >>> np.zeros(s)
            // array([[ 0.,  0.],
            //        [ 0.,  0.]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  s = (2,2);
            given=  np.zeros(s);
            expected=
                "array([[ 0.,  0.],\n" +
                "       [ 0.,  0.]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.zeros((2,), dtype=[('x', 'i4'), ('y', 'i4')]) # custom dtype
            // array([(0, 0), (0, 0)],
            //       dtype=[('x', '<i4'), ('y', '<i4')])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.zeros((2,), dtype=[('x', 'i4'), ('y', 'i4')]) # custom dtype;
            expected=
                "array([(0, 0), (0, 0)],\n" +
                "      dtype=[('x', '<i4'), ('y', '<i4')])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void zeros_likeTest()
        {
            // >>> x = np.arange(6)
            // >>> x = x.reshape((2, 3))
            // >>> x
            // array([[0, 1, 2],
            //        [3, 4, 5]])
            // >>> np.zeros_like(x)
            // array([[0, 0, 0],
            //        [0, 0, 0]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  x = np.arange(6);
            given=  x = x.reshape((2, 3));
            given=  x;
            expected=
                "array([[0, 1, 2],\n" +
                "       [3, 4, 5]])";
            Assert.AreEqual(expected, given.repr);
            given=  np.zeros_like(x);
            expected=
                "array([[0, 0, 0],\n" +
                "       [0, 0, 0]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> y = np.arange(3, dtype=float)
            // >>> y
            // array([ 0.,  1.,  2.])
            // >>> np.zeros_like(y)
            // array([ 0.,  0.,  0.])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  y = np.arange(3, dtype=float);
            given=  y;
            expected=
                "array([ 0.,  1.,  2.])";
            Assert.AreEqual(expected, given.repr);
            given=  np.zeros_like(y);
            expected=
                "array([ 0.,  0.,  0.])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void fullTest()
        {
            // >>> np.full((2, 2), np.inf)
            // array([[ inf,  inf],
            //        [ inf,  inf]])
            // >>> np.full((2, 2), 10)
            // array([[10, 10],
            //        [10, 10]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.full((2, 2), np.inf);
            expected=
                "array([[ inf,  inf],\n" +
                "       [ inf,  inf]])";
            Assert.AreEqual(expected, given.repr);
            given=  np.full((2, 2), 10);
            expected=
                "array([[10, 10],\n" +
                "       [10, 10]])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void full_likeTest()
        {
            // >>> x = np.arange(6, dtype=int)
            // >>> np.full_like(x, 1)
            // array([1, 1, 1, 1, 1, 1])
            // >>> np.full_like(x, 0.1)
            // array([0, 0, 0, 0, 0, 0])
            // >>> np.full_like(x, 0.1, dtype=np.double)
            // array([ 0.1,  0.1,  0.1,  0.1,  0.1,  0.1])
            // >>> np.full_like(x, np.nan, dtype=np.double)
            // array([ nan,  nan,  nan,  nan,  nan,  nan])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  x = np.arange(6, dtype=int);
            given=  np.full_like(x, 1);
            expected=
                "array([1, 1, 1, 1, 1, 1])";
            Assert.AreEqual(expected, given.repr);
            given=  np.full_like(x, 0.1);
            expected=
                "array([0, 0, 0, 0, 0, 0])";
            Assert.AreEqual(expected, given.repr);
            given=  np.full_like(x, 0.1, dtype=np.double);
            expected=
                "array([ 0.1,  0.1,  0.1,  0.1,  0.1,  0.1])";
            Assert.AreEqual(expected, given.repr);
            given=  np.full_like(x, np.nan, dtype=np.double);
            expected=
                "array([ nan,  nan,  nan,  nan,  nan,  nan])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> y = np.arange(6, dtype=np.double)
            // >>> np.full_like(y, 0.1)
            // array([ 0.1,  0.1,  0.1,  0.1,  0.1,  0.1])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  y = np.arange(6, dtype=np.double);
            given=  np.full_like(y, 0.1);
            expected=
                "array([ 0.1,  0.1,  0.1,  0.1,  0.1,  0.1])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void arrayTest()
        {
            // >>> np.array([1, 2, 3])
            // array([1, 2, 3])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.array([1, 2, 3]);
            expected=
                "array([1, 2, 3])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Upcasting:
            
            // >>> np.array([1, 2, 3.0])
            // array([ 1.,  2.,  3.])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.array([1, 2, 3.0]);
            expected=
                "array([ 1.,  2.,  3.])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // More than one dimension:
            
            // >>> np.array([[1, 2], [3, 4]])
            // array([[1, 2],
            //        [3, 4]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.array([[1, 2], [3, 4]]);
            expected=
                "array([[1, 2],\n" +
                "       [3, 4]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Minimum dimensions 2:
            
            // >>> np.array([1, 2, 3], ndmin=2)
            // array([[1, 2, 3]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.array([1, 2, 3], ndmin=2);
            expected=
                "array([[1, 2, 3]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Type provided:
            
            // >>> np.array([1, 2, 3], dtype=complex)
            // array([ 1.+0.j,  2.+0.j,  3.+0.j])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.array([1, 2, 3], dtype=complex);
            expected=
                "array([ 1.+0.j,  2.+0.j,  3.+0.j])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Data-type consisting of more than one element:
            
            // >>> x = np.array([(1,2),(3,4)],dtype=[('a','<i4'),('b','<i4')])
            // >>> x['a']
            // array([1, 3])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  x = np.array([(1,2),(3,4)],dtype=[('a','<i4'),('b','<i4')]);
            given=  x['a'];
            expected=
                "array([1, 3])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Creating an array from sub-classes:
            
            // >>> np.array(np.mat('1 2; 3 4'))
            // array([[1, 2],
            //        [3, 4]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.array(np.mat('1 2; 3 4'));
            expected=
                "array([[1, 2],\n" +
                "       [3, 4]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.array(np.mat('1 2; 3 4'), subok=True)
            // matrix([[1, 2],
            //         [3, 4]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.array(np.mat('1 2; 3 4'), subok=True);
            expected=
                "matrix([[1, 2],\n" +
                "        [3, 4]])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void asarrayTest()
        {
            // Convert a list into an array:
            
            // >>> a = [1, 2]
            // >>> np.asarray(a)
            // array([1, 2])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  a = [1, 2];
            given=  np.asarray(a);
            expected=
                "array([1, 2])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Existing arrays are not copied:
            
            // >>> a = np.array([1, 2])
            // >>> np.asarray(a) is a
            // True
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  a = np.array([1, 2]);
            given=  np.asarray(a) is a;
            expected=
                "True";
            Assert.AreEqual(expected, given.repr);
            #endif
            // If dtype is set, array is copied only if dtype does not match:
            
            // >>> a = np.array([1, 2], dtype=np.float32)
            // >>> np.asarray(a, dtype=np.float32) is a
            // True
            // >>> np.asarray(a, dtype=np.float64) is a
            // False
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  a = np.array([1, 2], dtype=np.float32);
            given=  np.asarray(a, dtype=np.float32) is a;
            expected=
                "True";
            Assert.AreEqual(expected, given.repr);
            given=  np.asarray(a, dtype=np.float64) is a;
            expected=
                "False";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Contrary to asanyarray, ndarray subclasses are not passed through:
            
            // >>> issubclass(np.recarray, np.ndarray)
            // True
            // >>> a = np.array([(1.0, 2), (3.0, 4)], dtype='f4,i4').view(np.recarray)
            // >>> np.asarray(a) is a
            // False
            // >>> np.asanyarray(a) is a
            // True
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  issubclass(np.recarray, np.ndarray);
            expected=
                "True";
            Assert.AreEqual(expected, given.repr);
            given=  a = np.array([(1.0, 2), (3.0, 4)], dtype='f4,i4').view(np.recarray);
            given=  np.asarray(a) is a;
            expected=
                "False";
            Assert.AreEqual(expected, given.repr);
            given=  np.asanyarray(a) is a;
            expected=
                "True";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void asanyarrayTest()
        {
            // Convert a list into an array:
            
            // >>> a = [1, 2]
            // >>> np.asanyarray(a)
            // array([1, 2])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  a = [1, 2];
            given=  np.asanyarray(a);
            expected=
                "array([1, 2])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Instances of ndarray subclasses are passed through as-is:
            
            // >>> a = np.array([(1.0, 2), (3.0, 4)], dtype='f4,i4').view(np.recarray)
            // >>> np.asanyarray(a) is a
            // True
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  a = np.array([(1.0, 2), (3.0, 4)], dtype='f4,i4').view(np.recarray);
            given=  np.asanyarray(a) is a;
            expected=
                "True";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void ascontiguousarrayTest()
        {
            // >>> x = np.arange(6).reshape(2,3)
            // >>> np.ascontiguousarray(x, dtype=np.float32)
            // array([[ 0.,  1.,  2.],
            //        [ 3.,  4.,  5.]], dtype=float32)
            // >>> x.flags['C_CONTIGUOUS']
            // True
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  x = np.arange(6).reshape(2,3);
            given=  np.ascontiguousarray(x, dtype=np.float32);
            expected=
                "array([[ 0.,  1.,  2.],\n" +
                "       [ 3.,  4.,  5.]], dtype=float32)";
            Assert.AreEqual(expected, given.repr);
            given=  x.flags['C_CONTIGUOUS'];
            expected=
                "True";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Note: This function returns an array with at least one-dimension (1-d) 
            // so it will not preserve 0-d arrays.
            
        }
        [TestMethod]
        public void asmatrixTest()
        {
            // >>> x = np.array([[1, 2], [3, 4]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  x = np.array([[1, 2], [3, 4]]);
            #endif
            // >>> m = np.asmatrix(x)
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  m = np.asmatrix(x);
            #endif
            // >>> x[0,0] = 5
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  x[0,0] = 5;
            #endif
            // >>> m
            // matrix([[5, 2],
            //         [3, 4]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  m;
            expected=
                "matrix([[5, 2],\n" +
                "        [3, 4]])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void copyTest()
        {
            // Create an array x, with a reference y and a copy z:
            
            // >>> x = np.array([1, 2, 3])
            // >>> y = x
            // >>> z = np.copy(x)
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  x = np.array([1, 2, 3]);
            given=  y = x;
            given=  z = np.copy(x);
            #endif
            // Note that, when we modify x, y changes, but not z:
            
            // >>> x[0] = 10
            // >>> x[0] == y[0]
            // True
            // >>> x[0] == z[0]
            // False
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  x[0] = 10;
            given=  x[0] == y[0];
            expected=
                "True";
            Assert.AreEqual(expected, given.repr);
            given=  x[0] == z[0];
            expected=
                "False";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void frombufferTest()
        {
            // >>> s = 'hello world'
            // >>> np.frombuffer(s, dtype='S1', count=5, offset=6)
            // array(['w', 'o', 'r', 'l', 'd'],
            //       dtype='|S1')
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  s = 'hello world';
            given=  np.frombuffer(s, dtype='S1', count=5, offset=6);
            expected=
                "array(['w', 'o', 'r', 'l', 'd'],\n" +
                "      dtype='|S1')";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.frombuffer(b'\x01\x02', dtype=np.uint8)
            // array([1, 2], dtype=uint8)
            // >>> np.frombuffer(b'\x01\x02\x03\x04\x05', dtype=np.uint8, count=3)
            // array([1, 2, 3], dtype=uint8)
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.frombuffer(b'\x01\x02', dtype=np.uint8);
            expected=
                "array([1, 2], dtype=uint8)";
            Assert.AreEqual(expected, given.repr);
            given=  np.frombuffer(b'\x01\x02\x03\x04\x05', dtype=np.uint8, count=3);
            expected=
                "array([1, 2, 3], dtype=uint8)";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void fromfileTest()
        {
            // Construct an ndarray:
            
            // >>> dt = np.dtype([('time', [('min', int), ('sec', int)]),
            // ...                ('temp', float)])
            // >>> x = np.zeros((1,), dtype=dt)
            // >>> x['time']['min'] = 10; x['temp'] = 98.25
            // >>> x
            // array([((10, 0), 98.25)],
            //       dtype=[('time', [('min', '<i4'), ('sec', '<i4')]), ('temp', '<f8')])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  dt = np.dtype([('time', [('min', int), ('sec', int)]),;
            expected=
                "...                ('temp', float)])";
            Assert.AreEqual(expected, given.repr);
            given=  x = np.zeros((1,), dtype=dt);
            given=  x['time']['min'] = 10; x['temp'] = 98.25;
            given=  x;
            expected=
                "array([((10, 0), 98.25)],\n" +
                "      dtype=[('time', [('min', '<i4'), ('sec', '<i4')]), ('temp', '<f8')])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Save the raw data to disk:
            
            // >>> import os
            // >>> fname = os.tmpnam()
            // >>> x.tofile(fname)
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  import os;
            given=  fname = os.tmpnam();
            given=  x.tofile(fname);
            #endif
            // Read the raw data from disk:
            
            // >>> np.fromfile(fname, dtype=dt)
            // array([((10, 0), 98.25)],
            //       dtype=[('time', [('min', '<i4'), ('sec', '<i4')]), ('temp', '<f8')])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.fromfile(fname, dtype=dt);
            expected=
                "array([((10, 0), 98.25)],\n" +
                "      dtype=[('time', [('min', '<i4'), ('sec', '<i4')]), ('temp', '<f8')])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // The recommended way to store and load data:
            
            // >>> np.save(fname, x)
            // >>> np.load(fname + '.npy')
            // array([((10, 0), 98.25)],
            //       dtype=[('time', [('min', '<i4'), ('sec', '<i4')]), ('temp', '<f8')])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.save(fname, x);
            given=  np.load(fname + '.npy');
            expected=
                "array([((10, 0), 98.25)],\n" +
                "      dtype=[('time', [('min', '<i4'), ('sec', '<i4')]), ('temp', '<f8')])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void fromfunctionTest()
        {
            // >>> np.fromfunction(lambda i, j: i == j, (3, 3), dtype=int)
            // array([[ True, False, False],
            //        [False,  True, False],
            //        [False, False,  True]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.fromfunction(lambda i, j: i == j, (3, 3), dtype=int);
            expected=
                "array([[ True, False, False],\n" +
                "       [False,  True, False],\n" +
                "       [False, False,  True]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.fromfunction(lambda i, j: i + j, (3, 3), dtype=int)
            // array([[0, 1, 2],
            //        [1, 2, 3],
            //        [2, 3, 4]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.fromfunction(lambda i, j: i + j, (3, 3), dtype=int);
            expected=
                "array([[0, 1, 2],\n" +
                "       [1, 2, 3],\n" +
                "       [2, 3, 4]])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void fromiterTest()
        {
            // >>> iterable = (x*x for x in range(5))
            // >>> np.fromiter(iterable, float)
            // array([  0.,   1.,   4.,   9.,  16.])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  iterable = (x*x for x in range(5));
            given=  np.fromiter(iterable, float);
            expected=
                "array([  0.,   1.,   4.,   9.,  16.])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void fromstringTest()
        {
            // >>> np.fromstring('1 2', dtype=int, sep=' ')
            // array([1, 2])
            // >>> np.fromstring('1, 2', dtype=int, sep=',')
            // array([1, 2])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.fromstring('1 2', dtype=int, sep=' ');
            expected=
                "array([1, 2])";
            Assert.AreEqual(expected, given.repr);
            given=  np.fromstring('1, 2', dtype=int, sep=',');
            expected=
                "array([1, 2])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void loadtxtTest()
        {
            // >>> from io import StringIO   # StringIO behaves like a file object
            // >>> c = StringIO(u"0 1\n2 3")
            // >>> np.loadtxt(c)
            // array([[ 0.,  1.],
            //        [ 2.,  3.]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  from io import StringIO   # StringIO behaves like a file object;
            given=  c = StringIO(u"0 1\n2 3");
            given=  np.loadtxt(c);
            expected=
                "array([[ 0.,  1.],\n" +
                "       [ 2.,  3.]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> d = StringIO(u"M 21 72\nF 35 58")
            // >>> np.loadtxt(d, dtype={'names': ('gender', 'age', 'weight'),
            // ...                      'formats': ('S1', 'i4', 'f4')})
            // array([('M', 21, 72.0), ('F', 35, 58.0)],
            //       dtype=[('gender', '|S1'), ('age', '<i4'), ('weight', '<f4')])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  d = StringIO(u"M 21 72\nF 35 58");
            given=  np.loadtxt(d, dtype={'names': ('gender', 'age', 'weight'),;
            expected=
                "...                      'formats': ('S1', 'i4', 'f4')})\n" +
                "array([('M', 21, 72.0), ('F', 35, 58.0)],\n" +
                "      dtype=[('gender', '|S1'), ('age', '<i4'), ('weight', '<f4')])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> c = StringIO(u"1,0,2\n3,0,4")
            // >>> x, y = np.loadtxt(c, delimiter=',', usecols=(0, 2), unpack=True)
            // >>> x
            // array([ 1.,  3.])
            // >>> y
            // array([ 2.,  4.])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  c = StringIO(u"1,0,2\n3,0,4");
            given=  x, y = np.loadtxt(c, delimiter=',', usecols=(0, 2), unpack=True);
            given=  x;
            expected=
                "array([ 1.,  3.])";
            Assert.AreEqual(expected, given.repr);
            given=  y;
            expected=
                "array([ 2.,  4.])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void arangeTest()
        {
            // >>> np.arange(3)
            // array([0, 1, 2])
            // >>> np.arange(3.0)
            // array([ 0.,  1.,  2.])
            // >>> np.arange(3,7)
            // array([3, 4, 5, 6])
            // >>> np.arange(3,7,2)
            // array([3, 5])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.arange(3);
            expected=
                "array([0, 1, 2])";
            Assert.AreEqual(expected, given.repr);
            given=  np.arange(3.0);
            expected=
                "array([ 0.,  1.,  2.])";
            Assert.AreEqual(expected, given.repr);
            given=  np.arange(3,7);
            expected=
                "array([3, 4, 5, 6])";
            Assert.AreEqual(expected, given.repr);
            given=  np.arange(3,7,2);
            expected=
                "array([3, 5])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void linspaceTest()
        {
            // >>> np.linspace(2.0, 3.0, num=5)
            // array([ 2.  ,  2.25,  2.5 ,  2.75,  3.  ])
            // >>> np.linspace(2.0, 3.0, num=5, endpoint=False)
            // array([ 2. ,  2.2,  2.4,  2.6,  2.8])
            // >>> np.linspace(2.0, 3.0, num=5, retstep=True)
            // (array([ 2.  ,  2.25,  2.5 ,  2.75,  3.  ]), 0.25)
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.linspace(2.0, 3.0, num=5);
            expected=
                "array([ 2.  ,  2.25,  2.5 ,  2.75,  3.  ])";
            Assert.AreEqual(expected, given.repr);
            given=  np.linspace(2.0, 3.0, num=5, endpoint=False);
            expected=
                "array([ 2. ,  2.2,  2.4,  2.6,  2.8])";
            Assert.AreEqual(expected, given.repr);
            given=  np.linspace(2.0, 3.0, num=5, retstep=True);
            expected=
                "(array([ 2.  ,  2.25,  2.5 ,  2.75,  3.  ]), 0.25)";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Graphical illustration:
            
            // >>> import matplotlib.pyplot as plt
            // >>> N = 8
            // >>> y = np.zeros(N)
            // >>> x1 = np.linspace(0, 10, N, endpoint=True)
            // >>> x2 = np.linspace(0, 10, N, endpoint=False)
            // >>> plt.plot(x1, y, 'o')
            // [<matplotlib.lines.Line2D object at 0x...>]
            // >>> plt.plot(x2, y + 0.5, 'o')
            // [<matplotlib.lines.Line2D object at 0x...>]
            // >>> plt.ylim([-0.5, 1])
            // (-0.5, 1)
            // >>> plt.show()
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  import matplotlib.pyplot as plt;
            given=  N = 8;
            given=  y = np.zeros(N);
            given=  x1 = np.linspace(0, 10, N, endpoint=True);
            given=  x2 = np.linspace(0, 10, N, endpoint=False);
            given=  plt.plot(x1, y, 'o');
            expected=
                "[<matplotlib.lines.Line2D object at 0x...>]";
            Assert.AreEqual(expected, given.repr);
            given=  plt.plot(x2, y + 0.5, 'o');
            expected=
                "[<matplotlib.lines.Line2D object at 0x...>]";
            Assert.AreEqual(expected, given.repr);
            given=  plt.ylim([-0.5, 1]);
            expected=
                "(-0.5, 1)";
            Assert.AreEqual(expected, given.repr);
            given=  plt.show();
            #endif
        }
        [TestMethod]
        public void logspaceTest()
        {
            // >>> np.logspace(2.0, 3.0, num=4)
            // array([  100.        ,   215.443469  ,   464.15888336,  1000.        ])
            // >>> np.logspace(2.0, 3.0, num=4, endpoint=False)
            // array([ 100.        ,  177.827941  ,  316.22776602,  562.34132519])
            // >>> np.logspace(2.0, 3.0, num=4, base=2.0)
            // array([ 4.        ,  5.0396842 ,  6.34960421,  8.        ])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.logspace(2.0, 3.0, num=4);
            expected=
                "array([  100.        ,   215.443469  ,   464.15888336,  1000.        ])";
            Assert.AreEqual(expected, given.repr);
            given=  np.logspace(2.0, 3.0, num=4, endpoint=False);
            expected=
                "array([ 100.        ,  177.827941  ,  316.22776602,  562.34132519])";
            Assert.AreEqual(expected, given.repr);
            given=  np.logspace(2.0, 3.0, num=4, base=2.0);
            expected=
                "array([ 4.        ,  5.0396842 ,  6.34960421,  8.        ])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Graphical illustration:
            
            // >>> import matplotlib.pyplot as plt
            // >>> N = 10
            // >>> x1 = np.logspace(0.1, 1, N, endpoint=True)
            // >>> x2 = np.logspace(0.1, 1, N, endpoint=False)
            // >>> y = np.zeros(N)
            // >>> plt.plot(x1, y, 'o')
            // [<matplotlib.lines.Line2D object at 0x...>]
            // >>> plt.plot(x2, y + 0.5, 'o')
            // [<matplotlib.lines.Line2D object at 0x...>]
            // >>> plt.ylim([-0.5, 1])
            // (-0.5, 1)
            // >>> plt.show()
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  import matplotlib.pyplot as plt;
            given=  N = 10;
            given=  x1 = np.logspace(0.1, 1, N, endpoint=True);
            given=  x2 = np.logspace(0.1, 1, N, endpoint=False);
            given=  y = np.zeros(N);
            given=  plt.plot(x1, y, 'o');
            expected=
                "[<matplotlib.lines.Line2D object at 0x...>]";
            Assert.AreEqual(expected, given.repr);
            given=  plt.plot(x2, y + 0.5, 'o');
            expected=
                "[<matplotlib.lines.Line2D object at 0x...>]";
            Assert.AreEqual(expected, given.repr);
            given=  plt.ylim([-0.5, 1]);
            expected=
                "(-0.5, 1)";
            Assert.AreEqual(expected, given.repr);
            given=  plt.show();
            #endif
        }
        [TestMethod]
        public void geomspaceTest()
        {
            // >>> np.geomspace(1, 1000, num=4)
            // array([    1.,    10.,   100.,  1000.])
            // >>> np.geomspace(1, 1000, num=3, endpoint=False)
            // array([   1.,   10.,  100.])
            // >>> np.geomspace(1, 1000, num=4, endpoint=False)
            // array([   1.        ,    5.62341325,   31.6227766 ,  177.827941  ])
            // >>> np.geomspace(1, 256, num=9)
            // array([   1.,    2.,    4.,    8.,   16.,   32.,   64.,  128.,  256.])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.geomspace(1, 1000, num=4);
            expected=
                "array([    1.,    10.,   100.,  1000.])";
            Assert.AreEqual(expected, given.repr);
            given=  np.geomspace(1, 1000, num=3, endpoint=False);
            expected=
                "array([   1.,   10.,  100.])";
            Assert.AreEqual(expected, given.repr);
            given=  np.geomspace(1, 1000, num=4, endpoint=False);
            expected=
                "array([   1.        ,    5.62341325,   31.6227766 ,  177.827941  ])";
            Assert.AreEqual(expected, given.repr);
            given=  np.geomspace(1, 256, num=9);
            expected=
                "array([   1.,    2.,    4.,    8.,   16.,   32.,   64.,  128.,  256.])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Note that the above may not produce exact integers:
            
            // >>> np.geomspace(1, 256, num=9, dtype=int)
            // array([  1,   2,   4,   7,  16,  32,  63, 127, 256])
            // >>> np.around(np.geomspace(1, 256, num=9)).astype(int)
            // array([  1,   2,   4,   8,  16,  32,  64, 128, 256])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.geomspace(1, 256, num=9, dtype=int);
            expected=
                "array([  1,   2,   4,   7,  16,  32,  63, 127, 256])";
            Assert.AreEqual(expected, given.repr);
            given=  np.around(np.geomspace(1, 256, num=9)).astype(int);
            expected=
                "array([  1,   2,   4,   8,  16,  32,  64, 128, 256])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Negative, decreasing, and complex inputs are allowed:
            
            // >>> np.geomspace(1000, 1, num=4)
            // array([ 1000.,   100.,    10.,     1.])
            // >>> np.geomspace(-1000, -1, num=4)
            // array([-1000.,  -100.,   -10.,    -1.])
            // >>> np.geomspace(1j, 1000j, num=4)  # Straight line
            // array([ 0.   +1.j,  0.  +10.j,  0. +100.j,  0.+1000.j])
            // >>> np.geomspace(-1+0j, 1+0j, num=5)  # Circle
            // array([-1.00000000+0.j        , -0.70710678+0.70710678j,
            //         0.00000000+1.j        ,  0.70710678+0.70710678j,
            //         1.00000000+0.j        ])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.geomspace(1000, 1, num=4);
            expected=
                "array([ 1000.,   100.,    10.,     1.])";
            Assert.AreEqual(expected, given.repr);
            given=  np.geomspace(-1000, -1, num=4);
            expected=
                "array([-1000.,  -100.,   -10.,    -1.])";
            Assert.AreEqual(expected, given.repr);
            given=  np.geomspace(1j, 1000j, num=4)  # Straight line;
            expected=
                "array([ 0.   +1.j,  0.  +10.j,  0. +100.j,  0.+1000.j])";
            Assert.AreEqual(expected, given.repr);
            given=  np.geomspace(-1+0j, 1+0j, num=5)  # Circle;
            expected=
                "array([-1.00000000+0.j        , -0.70710678+0.70710678j,\n" +
                "        0.00000000+1.j        ,  0.70710678+0.70710678j,\n" +
                "        1.00000000+0.j        ])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Graphical illustration of endpoint parameter:
            
            // >>> import matplotlib.pyplot as plt
            // >>> N = 10
            // >>> y = np.zeros(N)
            // >>> plt.semilogx(np.geomspace(1, 1000, N, endpoint=True), y + 1, 'o')
            // >>> plt.semilogx(np.geomspace(1, 1000, N, endpoint=False), y + 2, 'o')
            // >>> plt.axis([0.5, 2000, 0, 3])
            // >>> plt.grid(True, color='0.7', linestyle='-', which='both', axis='both')
            // >>> plt.show()
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  import matplotlib.pyplot as plt;
            given=  N = 10;
            given=  y = np.zeros(N);
            given=  plt.semilogx(np.geomspace(1, 1000, N, endpoint=True), y + 1, 'o');
            given=  plt.semilogx(np.geomspace(1, 1000, N, endpoint=False), y + 2, 'o');
            given=  plt.axis([0.5, 2000, 0, 3]);
            given=  plt.grid(True, color='0.7', linestyle='-', which='both', axis='both');
            given=  plt.show();
            #endif
        }
        [TestMethod]
        public void meshgridTest()
        {
            // >>> nx, ny = (3, 2)
            // >>> x = np.linspace(0, 1, nx)
            // >>> y = np.linspace(0, 1, ny)
            // >>> xv, yv = np.meshgrid(x, y)
            // >>> xv
            // array([[ 0. ,  0.5,  1. ],
            //        [ 0. ,  0.5,  1. ]])
            // >>> yv
            // array([[ 0.,  0.,  0.],
            //        [ 1.,  1.,  1.]])
            // >>> xv, yv = np.meshgrid(x, y, sparse=True)  # make sparse output arrays
            // >>> xv
            // array([[ 0. ,  0.5,  1. ]])
            // >>> yv
            // array([[ 0.],
            //        [ 1.]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  nx, ny = (3, 2);
            given=  x = np.linspace(0, 1, nx);
            given=  y = np.linspace(0, 1, ny);
            given=  xv, yv = np.meshgrid(x, y);
            given=  xv;
            expected=
                "array([[ 0. ,  0.5,  1. ],\n" +
                "       [ 0. ,  0.5,  1. ]])";
            Assert.AreEqual(expected, given.repr);
            given=  yv;
            expected=
                "array([[ 0.,  0.,  0.],\n" +
                "       [ 1.,  1.,  1.]])";
            Assert.AreEqual(expected, given.repr);
            given=  xv, yv = np.meshgrid(x, y, sparse=True)  # make sparse output arrays;
            given=  xv;
            expected=
                "array([[ 0. ,  0.5,  1. ]])";
            Assert.AreEqual(expected, given.repr);
            given=  yv;
            expected=
                "array([[ 0.],\n" +
                "       [ 1.]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // meshgrid is very useful to evaluate functions on a grid.
            
            // >>> import matplotlib.pyplot as plt
            // >>> x = np.arange(-5, 5, 0.1)
            // >>> y = np.arange(-5, 5, 0.1)
            // >>> xx, yy = np.meshgrid(x, y, sparse=True)
            // >>> z = np.sin(xx**2 + yy**2) / (xx**2 + yy**2)
            // >>> h = plt.contourf(x,y,z)
            // >>> plt.show()
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  import matplotlib.pyplot as plt;
            given=  x = np.arange(-5, 5, 0.1);
            given=  y = np.arange(-5, 5, 0.1);
            given=  xx, yy = np.meshgrid(x, y, sparse=True);
            given=  z = np.sin(xx**2 + yy**2) / (xx**2 + yy**2);
            given=  h = plt.contourf(x,y,z);
            given=  plt.show();
            #endif
        }
        [TestMethod]
        public void diagTest()
        {
            // >>> x = np.arange(9).reshape((3,3))
            // >>> x
            // array([[0, 1, 2],
            //        [3, 4, 5],
            //        [6, 7, 8]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  x = np.arange(9).reshape((3,3));
            given=  x;
            expected=
                "array([[0, 1, 2],\n" +
                "       [3, 4, 5],\n" +
                "       [6, 7, 8]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.diag(x)
            // array([0, 4, 8])
            // >>> np.diag(x, k=1)
            // array([1, 5])
            // >>> np.diag(x, k=-1)
            // array([3, 7])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.diag(x);
            expected=
                "array([0, 4, 8])";
            Assert.AreEqual(expected, given.repr);
            given=  np.diag(x, k=1);
            expected=
                "array([1, 5])";
            Assert.AreEqual(expected, given.repr);
            given=  np.diag(x, k=-1);
            expected=
                "array([3, 7])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.diag(np.diag(x))
            // array([[0, 0, 0],
            //        [0, 4, 0],
            //        [0, 0, 8]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.diag(np.diag(x));
            expected=
                "array([[0, 0, 0],\n" +
                "       [0, 4, 0],\n" +
                "       [0, 0, 8]])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void diagflatTest()
        {
            // >>> np.diagflat([[1,2], [3,4]])
            // array([[1, 0, 0, 0],
            //        [0, 2, 0, 0],
            //        [0, 0, 3, 0],
            //        [0, 0, 0, 4]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.diagflat([[1,2], [3,4]]);
            expected=
                "array([[1, 0, 0, 0],\n" +
                "       [0, 2, 0, 0],\n" +
                "       [0, 0, 3, 0],\n" +
                "       [0, 0, 0, 4]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.diagflat([1,2], 1)
            // array([[0, 1, 0],
            //        [0, 0, 2],
            //        [0, 0, 0]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.diagflat([1,2], 1);
            expected=
                "array([[0, 1, 0],\n" +
                "       [0, 0, 2],\n" +
                "       [0, 0, 0]])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void triTest()
        {
            // >>> np.tri(3, 5, 2, dtype=int)
            // array([[1, 1, 1, 0, 0],
            //        [1, 1, 1, 1, 0],
            //        [1, 1, 1, 1, 1]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.tri(3, 5, 2, dtype=int);
            expected=
                "array([[1, 1, 1, 0, 0],\n" +
                "       [1, 1, 1, 1, 0],\n" +
                "       [1, 1, 1, 1, 1]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.tri(3, 5, -1)
            // array([[ 0.,  0.,  0.,  0.,  0.],
            //        [ 1.,  0.,  0.,  0.,  0.],
            //        [ 1.,  1.,  0.,  0.,  0.]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.tri(3, 5, -1);
            expected=
                "array([[ 0.,  0.,  0.,  0.,  0.],\n" +
                "       [ 1.,  0.,  0.,  0.,  0.],\n" +
                "       [ 1.,  1.,  0.,  0.,  0.]])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void trilTest()
        {
            // >>> np.tril([[1,2,3],[4,5,6],[7,8,9],[10,11,12]], -1)
            // array([[ 0,  0,  0],
            //        [ 4,  0,  0],
            //        [ 7,  8,  0],
            //        [10, 11, 12]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.tril([[1,2,3],[4,5,6],[7,8,9],[10,11,12]], -1);
            expected=
                "array([[ 0,  0,  0],\n" +
                "       [ 4,  0,  0],\n" +
                "       [ 7,  8,  0],\n" +
                "       [10, 11, 12]])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void vanderTest()
        {
            // >>> x = np.array([1, 2, 3, 5])
            // >>> N = 3
            // >>> np.vander(x, N)
            // array([[ 1,  1,  1],
            //        [ 4,  2,  1],
            //        [ 9,  3,  1],
            //        [25,  5,  1]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  x = np.array([1, 2, 3, 5]);
            given=  N = 3;
            given=  np.vander(x, N);
            expected=
                "array([[ 1,  1,  1],\n" +
                "       [ 4,  2,  1],\n" +
                "       [ 9,  3,  1],\n" +
                "       [25,  5,  1]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.column_stack([x**(N-1-i) for i in range(N)])
            // array([[ 1,  1,  1],
            //        [ 4,  2,  1],
            //        [ 9,  3,  1],
            //        [25,  5,  1]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.column_stack([x**(N-1-i) for i in range(N)]);
            expected=
                "array([[ 1,  1,  1],\n" +
                "       [ 4,  2,  1],\n" +
                "       [ 9,  3,  1],\n" +
                "       [25,  5,  1]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> x = np.array([1, 2, 3, 5])
            // >>> np.vander(x)
            // array([[  1,   1,   1,   1],
            //        [  8,   4,   2,   1],
            //        [ 27,   9,   3,   1],
            //        [125,  25,   5,   1]])
            // >>> np.vander(x, increasing=True)
            // array([[  1,   1,   1,   1],
            //        [  1,   2,   4,   8],
            //        [  1,   3,   9,  27],
            //        [  1,   5,  25, 125]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  x = np.array([1, 2, 3, 5]);
            given=  np.vander(x);
            expected=
                "array([[  1,   1,   1,   1],\n" +
                "       [  8,   4,   2,   1],\n" +
                "       [ 27,   9,   3,   1],\n" +
                "       [125,  25,   5,   1]])";
            Assert.AreEqual(expected, given.repr);
            given=  np.vander(x, increasing=True);
            expected=
                "array([[  1,   1,   1,   1],\n" +
                "       [  1,   2,   4,   8],\n" +
                "       [  1,   3,   9,  27],\n" +
                "       [  1,   5,  25, 125]])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // The determinant of a square Vandermonde matrix is the product
            // of the differences between the values of the input vector:
            
            // >>> np.linalg.det(np.vander(x))
            // 48.000000000000043
            // >>> (5-3)*(5-2)*(5-1)*(3-2)*(3-1)*(2-1)
            // 48
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.linalg.det(np.vander(x));
            expected=
                "48.000000000000043";
            Assert.AreEqual(expected, given.repr);
            given=  (5-3)*(5-2)*(5-1)*(3-2)*(3-1)*(2-1);
            expected=
                "48";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void matTest()
        {
            // >>> x = np.array([[1, 2], [3, 4]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  x = np.array([[1, 2], [3, 4]]);
            #endif
            // >>> m = np.asmatrix(x)
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  m = np.asmatrix(x);
            #endif
            // >>> x[0,0] = 5
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  x[0,0] = 5;
            #endif
            // >>> m
            // matrix([[5, 2],
            //         [3, 4]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  m;
            expected=
                "matrix([[5, 2],\n" +
                "        [3, 4]])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        [TestMethod]
        public void bmatTest()
        {
            // >>> A = np.mat('1 1; 1 1')
            // >>> B = np.mat('2 2; 2 2')
            // >>> C = np.mat('3 4; 5 6')
            // >>> D = np.mat('7 8; 9 0')
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  A = np.mat('1 1; 1 1');
            given=  B = np.mat('2 2; 2 2');
            given=  C = np.mat('3 4; 5 6');
            given=  D = np.mat('7 8; 9 0');
            #endif
            // All the following expressions construct the same block matrix:
            
            // >>> np.bmat([[A, B], [C, D]])
            // matrix([[1, 1, 2, 2],
            //         [1, 1, 2, 2],
            //         [3, 4, 7, 8],
            //         [5, 6, 9, 0]])
            // >>> np.bmat(np.r_[np.c_[A, B], np.c_[C, D]])
            // matrix([[1, 1, 2, 2],
            //         [1, 1, 2, 2],
            //         [3, 4, 7, 8],
            //         [5, 6, 9, 0]])
            // >>> np.bmat('A,B; C,D')
            // matrix([[1, 1, 2, 2],
            //         [1, 1, 2, 2],
            //         [3, 4, 7, 8],
            //         [5, 6, 9, 0]])
            // 
            
            #if TODO
            object given = null;
            object expected = null;
            given=  np.bmat([[A, B], [C, D]]);
            expected=
                "matrix([[1, 1, 2, 2],\n" +
                "        [1, 1, 2, 2],\n" +
                "        [3, 4, 7, 8],\n" +
                "        [5, 6, 9, 0]])";
            Assert.AreEqual(expected, given.repr);
            given=  np.bmat(np.r_[np.c_[A, B], np.c_[C, D]]);
            expected=
                "matrix([[1, 1, 2, 2],\n" +
                "        [1, 1, 2, 2],\n" +
                "        [3, 4, 7, 8],\n" +
                "        [5, 6, 9, 0]])";
            Assert.AreEqual(expected, given.repr);
            given=  np.bmat('A,B; C,D');
            expected=
                "matrix([[1, 1, 2, 2],\n" +
                "        [1, 1, 2, 2],\n" +
                "        [3, 4, 7, 8],\n" +
                "        [5, 6, 9, 0]])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
    }
}
