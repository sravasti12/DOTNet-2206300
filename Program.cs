﻿// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        DocumentFactory factory;

        factory = new WordFactory();
        IDocument doc1 = factory.CreateDocument();
        doc1.Open();

        factory = new PdfFactory();
        IDocument doc2 = factory.CreateDocument();
        doc2.Open();

        factory = new ExcelFactory();
        IDocument doc3 = factory.CreateDocument();
        doc3.Open();
    }
}

