using DSA.Arrays.Array_Interface;
using DSA.Arrays.Array_service;
using DSA.leetcode.Algorithms;
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
            services.AddScoped<Array_interface, Array_Service>();
            services.AddScoped<IAlgorithms_leedcode, Algorithims_leedcode>();

            return services;
        }
    }
}
