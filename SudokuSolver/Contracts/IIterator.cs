﻿namespace SudokuSolver.Contracts
{
    public interface IIterator
    {
        void First();
        void Next();
        bool HasNext();
    }
}