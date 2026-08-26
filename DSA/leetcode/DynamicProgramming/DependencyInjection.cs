using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.leetcode.DynamicProgramming
{
    public static class DependencyInjection
    {
        public static IServiceCollection DynamicProgrammingAddApplicationServices(
        this IServiceCollection services)
        {
            services.AddScoped<ILeetcodeDynamicProgramming, LeetcodeDynamicPrograming>();

            return services;
        }
    }
}
