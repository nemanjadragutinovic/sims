/***********************************************************************
 * Module:  Blog.cs
 * Author:  stefan
 * Purpose: Definition of the Class Model.BlogAndSurvey.Blog
 ***********************************************************************/

using System;

namespace Model.BlogAndSurvey
{
   public class Blog
   {
      private string title;
      private string content;
      
      public System.Collections.ArrayList article;
      
      /// <summary>
      /// Property for collection of Article
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Article
      {
         get
         {
            if (article == null)
               article = new System.Collections.ArrayList();
            return article;
         }
         set
         {
            RemoveAllArticle();
            if (value != null)
            {
               foreach (Article oArticle in value)
                  AddArticle(oArticle);
            }
         }
      }
      
      /// <summary>
      /// Add a new Article in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddArticle(Article newArticle)
      {
         if (newArticle == null)
            return;
         if (this.article == null)
            this.article = new System.Collections.ArrayList();
         if (!this.article.Contains(newArticle))
            this.article.Add(newArticle);
      }
      
      /// <summary>
      /// Remove an existing Article from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveArticle(Article oldArticle)
      {
         if (oldArticle == null)
            return;
         if (this.article != null)
            if (this.article.Contains(oldArticle))
               this.article.Remove(oldArticle);
      }
      
      /// <summary>
      /// Remove all instances of Article from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllArticle()
      {
         if (article != null)
            article.Clear();
      }
   
   }
}