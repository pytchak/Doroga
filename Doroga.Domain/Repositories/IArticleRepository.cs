using System;
using System.Collections.Generic;
using System.Text;
using Doroga.Domain.Entities;

namespace Doroga.Domain.Repositories
{
    public interface IArticleRepository
    {
        IEnumerable<ArticleEntity> GetAllArticles();
        ArticleEntity GetArticleById(string id);
        void CreateArticle(ArticleEntity articleEntities);
        void UpdateArticle(ArticleEntity articleEntities);
    }
}
