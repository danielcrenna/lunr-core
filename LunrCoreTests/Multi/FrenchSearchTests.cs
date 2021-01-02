﻿using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Lunr;
using Xunit;
using Index = Lunr.Index;

namespace LunrCoreTests.Multi
{
    public class FrenchSearchTests
    {
        private readonly Document[] _documents = new[]
        {
            new Document
            {
                { "id", "a" },
                { "title", "France" },
                { "body", "La France Prononciation du titre dans sa version originale Écouter, officiellement la République française Prononciation du titre dans sa version originale Écouter, est un État transcontinental souverain, dont le territoire métropolitain est situé en Europe de l'Ouest. Ce dernier a des frontières terrestres avec la Belgique, le Luxembourg, l'Allemagne, la Suisse, l'Italie, l'Espagne et les principautés d'Andorre et de MonacoN 6,6 et dispose d'importantes façades maritimes dans l'Atlantique, la Manche, la mer du Nord et la Méditerranée. Son territoire ultramarin s'étend dans les océans Indien7, Atlantique8 et Pacifique9 ainsi que sur le continent sud-américain10 et a des frontières terrestres avec le Brésil, le Suriname et le Royaume des Pays-Bas." }
            },
            new Document
            {
                { "id", "b" },
                { "title", "Politique et administration" },
                { "body", "La France est une démocratie libérale, dont le gouvernement a la forme d’une république. Les fondements de l’organisation politique et administrative actuelle de la France ont été fixés en 1958 par la Constitution de la Cinquième République. Selon l’article premier de cette constitution, « la France est une République indivisible, laïque, démocratique et sociale ». Depuis 2003, ce même article affirme en outre que « son organisation est décentralisée continuelle" }
            },
        };

        [Theory]
        [InlineData("France", 2)]
        [InlineData("gouvernement", 1)]
        [InlineData("continuellement", 1)]
        [InlineData("inexistent", 0)]
        public async Task FindTheWord(string word, int resultCount)
        {
            Index idx = await GetPlainIndex();
            IList<Result> results = await idx.Search(word).ToList();
            Assert.Equal(resultCount, results.Count);
        }
        
        private async Task<Index> GetPlainIndex()
        {
            return await Index.Fr.Build(async builder =>
            {
                builder.ReferenceField = "id";

                builder
                    .AddField("title")
                    .AddField("body", boost: 10);

                foreach (Document doc in _documents)
                {
                    await builder.Add(doc);
                }
            });
        }
    }
}