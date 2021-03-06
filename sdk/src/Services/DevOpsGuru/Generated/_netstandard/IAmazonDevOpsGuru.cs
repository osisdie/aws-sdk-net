/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DevOpsGuru.Model;

namespace Amazon.DevOpsGuru
{
    /// <summary>
    /// Interface for accessing DevOpsGuru
    ///
    /// 
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonDevOpsGuru : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDevOpsGuruPaginatorFactory Paginators { get; }
#endif
                
        #region  AddNotificationChannel



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddNotificationChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddNotificationChannel service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/AddNotificationChannel">REST API Reference for AddNotificationChannel Operation</seealso>
        Task<AddNotificationChannelResponse> AddNotificationChannelAsync(AddNotificationChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccountHealth



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountHealth service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeAccountHealth">REST API Reference for DescribeAccountHealth Operation</seealso>
        Task<DescribeAccountHealthResponse> DescribeAccountHealthAsync(DescribeAccountHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccountOverview



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountOverview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountOverview service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeAccountOverview">REST API Reference for DescribeAccountOverview Operation</seealso>
        Task<DescribeAccountOverviewResponse> DescribeAccountOverviewAsync(DescribeAccountOverviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAnomaly



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnomaly service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAnomaly service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeAnomaly">REST API Reference for DescribeAnomaly Operation</seealso>
        Task<DescribeAnomalyResponse> DescribeAnomalyAsync(DescribeAnomalyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInsight



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInsight service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInsight service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeInsight">REST API Reference for DescribeInsight Operation</seealso>
        Task<DescribeInsightResponse> DescribeInsightAsync(DescribeInsightRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeResourceCollectionHealth



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceCollectionHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeResourceCollectionHealth service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeResourceCollectionHealth">REST API Reference for DescribeResourceCollectionHealth Operation</seealso>
        Task<DescribeResourceCollectionHealthResponse> DescribeResourceCollectionHealthAsync(DescribeResourceCollectionHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeServiceIntegration



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServiceIntegration service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/DescribeServiceIntegration">REST API Reference for DescribeServiceIntegration Operation</seealso>
        Task<DescribeServiceIntegrationResponse> DescribeServiceIntegrationAsync(DescribeServiceIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetResourceCollection



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceCollection service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/GetResourceCollection">REST API Reference for GetResourceCollection Operation</seealso>
        Task<GetResourceCollectionResponse> GetResourceCollectionAsync(GetResourceCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAnomaliesForInsight



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomaliesForInsight service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnomaliesForInsight service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListAnomaliesForInsight">REST API Reference for ListAnomaliesForInsight Operation</seealso>
        Task<ListAnomaliesForInsightResponse> ListAnomaliesForInsightAsync(ListAnomaliesForInsightRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEvents



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEvents service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListEvents">REST API Reference for ListEvents Operation</seealso>
        Task<ListEventsResponse> ListEventsAsync(ListEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInsights



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInsights service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInsights service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListInsights">REST API Reference for ListInsights Operation</seealso>
        Task<ListInsightsResponse> ListInsightsAsync(ListInsightsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNotificationChannels



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotificationChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotificationChannels service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListNotificationChannels">REST API Reference for ListNotificationChannels Operation</seealso>
        Task<ListNotificationChannelsResponse> ListNotificationChannelsAsync(ListNotificationChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRecommendations



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        Task<ListRecommendationsResponse> ListRecommendationsAsync(ListRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutFeedback



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutFeedback service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        Task<PutFeedbackResponse> PutFeedbackAsync(PutFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveNotificationChannel



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveNotificationChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveNotificationChannel service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/RemoveNotificationChannel">REST API Reference for RemoveNotificationChannel Operation</seealso>
        Task<RemoveNotificationChannelResponse> RemoveNotificationChannelAsync(RemoveNotificationChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchInsights



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchInsights service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchInsights service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/SearchInsights">REST API Reference for SearchInsights Operation</seealso>
        Task<SearchInsightsResponse> SearchInsightsAsync(SearchInsightsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateResourceCollection



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResourceCollection service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/UpdateResourceCollection">REST API Reference for UpdateResourceCollection Operation</seealso>
        Task<UpdateResourceCollectionResponse> UpdateResourceCollectionAsync(UpdateResourceCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateServiceIntegration



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceIntegration service method, as returned by DevOpsGuru.</returns>
        /// <exception cref="Amazon.DevOpsGuru.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DevOpsGuru.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-guru-2020-12-01/UpdateServiceIntegration">REST API Reference for UpdateServiceIntegration Operation</seealso>
        Task<UpdateServiceIntegrationResponse> UpdateServiceIntegrationAsync(UpdateServiceIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}